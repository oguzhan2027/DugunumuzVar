using DugunumuzVar.DataAccessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Repositories;
using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.DataAccessLayer.EntityFramework
{
    public class EfCouponDal : GenericRepository<Coupon>, ICouponDal
    {
       
    }
}
