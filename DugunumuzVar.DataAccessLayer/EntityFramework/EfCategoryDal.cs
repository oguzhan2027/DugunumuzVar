using Microsoft.EntityFrameworkCore;
using DugunumuzVar.DataAccessLayer.Abstract;
using DugunumuzVar.DataAccessLayer.Concrete;
using DugunumuzVar.DataAccessLayer.Repositories;
using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public List<Category> GetCategoriesWithProduct()
        {
            using var context = new Context();
            return context.Categories.Include(x=>x.Products).ToList();
        }
    }
}
