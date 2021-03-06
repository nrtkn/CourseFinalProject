using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> GetAll()
        {
            //İş kodları
            return _categoryDAL.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //İş kodları
            return _categoryDAL.Get(c => c.CategoryID == categoryId);
        }
    }
}
