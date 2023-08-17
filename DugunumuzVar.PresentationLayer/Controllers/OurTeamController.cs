using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;
using DugunumuzVar.BusinessLayer.ValidationRules.OurTeamValidator;
using DugunumuzVar.EntityLayer.Concrete;

namespace DugunumuzVar.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly IOurTeamService _ourTeamService;

        public OurTeamController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IActionResult Index()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddOurTeam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddOurTeam(OurTeam ourTeam)
        {
            CreateOurTeamValidator createOurTeamValidator=new CreateOurTeamValidator();
            ValidationResult result=createOurTeamValidator.Validate(ourTeam);
            if(result.IsValid)
            {              
                ourTeam.ImageUrl = "/pizzapan-starter/pexels-andrea-piacquadio-874158.jpg";
                ourTeam.Facebook = "https://github.com/oguzhan2027";
                ourTeam.Twitter = "https://github.com/oguzhan2027";
                _ourTeamService.Tİnsert(ourTeam);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View();
            }
        }

        [HttpGet]
        public IActionResult UpdateOurTeam(int id)
        {
            var values = _ourTeamService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateOurTeam(OurTeam ourTeam)
        {
            _ourTeamService.TUpdate(ourTeam);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteOurTeam(int id)
        {
            var x=_ourTeamService.TGetByID(id);            
            _ourTeamService.TDelete(x);
            return RedirectToAction("Index");
        }
    }
}
