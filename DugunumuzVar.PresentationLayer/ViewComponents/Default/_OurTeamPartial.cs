using Microsoft.AspNetCore.Mvc;
using DugunumuzVar.BusinessLayer.Abstract;

namespace DugunumuzVar.PresentationLayer.ViewComponents.Default
{
    public class _OurTeamPartial:ViewComponent
    {
        private readonly IOurTeamService _ourTeamService;

        public _OurTeamPartial(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ourTeamService.TGetList();
            return View(values);
        }
    }
}
