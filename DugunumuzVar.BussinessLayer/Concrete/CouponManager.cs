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
    public class CouponManager : ICouponService
    {
        private readonly ICouponDal _couponDal;

        public CouponManager(ICouponDal couponDal)
        {
            _couponDal = couponDal;
        }

        public void TDelete(Coupon t)
        {
            throw new NotImplementedException();
        }

        public Coupon TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coupon> TGetList()
        {
           return _couponDal.GetList();
        }

        public void TUpdate(Coupon t)
        {
            throw new NotImplementedException();
        }

        public void Tİnsert(Coupon t)
        {
            _couponDal.İnsert(t);
        }
    }
}
