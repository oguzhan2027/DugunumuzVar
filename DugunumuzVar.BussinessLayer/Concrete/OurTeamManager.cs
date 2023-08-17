using DugunumuzVar.BusinessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Abstract;
using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.BusinessLayer.Concrete
{
    public class OurTeamManager : IOurTeamService
    {
        private readonly IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void TDelete(OurTeam t)
        {
            _ourTeamDal.Delete(t);
        }

        public OurTeam TGetByID(int id)
        {
            return _ourTeamDal.GetByID(id);
        }

        public List<OurTeam> TGetList()
        {
            return _ourTeamDal.GetList();
        }

        public void TUpdate(OurTeam t)
        {
            _ourTeamDal.Update(t);
        }

        public void Tİnsert(OurTeam t)
        {
            _ourTeamDal.İnsert(t);
        }
    }
}
