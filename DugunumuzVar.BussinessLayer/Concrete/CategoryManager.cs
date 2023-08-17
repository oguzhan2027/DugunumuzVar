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
    public class CategoryManager :  ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetCategoriesWithProduct()
        {
            return _categoryDal.GetCategoriesWithProduct();
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        public void Tİnsert(Category t)
        {
            _categoryDal.İnsert(t);
        }
    }
}
