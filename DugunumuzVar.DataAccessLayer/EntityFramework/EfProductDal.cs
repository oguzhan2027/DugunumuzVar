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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            using var context=new Context();
            return context.Products.Include(x => x.Category).ToList();
        }

        public List<Product> GetProductsWithCategoryName(int categoryID)
        {
            using var context = new Context();
            return context.Products.Include(x => x.Category).Where(x=>x.CategoryID==categoryID).ToList();
        }
    }
}
