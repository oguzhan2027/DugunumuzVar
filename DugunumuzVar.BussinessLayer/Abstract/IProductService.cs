﻿using DugunumuzVar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugunumuzVar.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategory();
        List<Product> TGetProductsWithCategoryName(int categoryID);
    }
}