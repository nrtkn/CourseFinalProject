using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public IResult Add(Product product)
        {
            _productDAL.Add(product);

            if (product.ProductName.Length < 5)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
                return new SuccessDataResult<List<Product>>(_productDAL.GetAll(), true, Messages.ProductListed);
        }
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDAL.GetAll(p=>p.CategoryID == id));
        }

        public IDataResult<Product> GetById(int prodID)
        {
            return new SuccessDataResult<Product>(_productDAL.Get(x=>x.ProductID == prodID));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
           return new SuccessDataResult<List<Product>>(_productDAL.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetail()
        {
            return new SuccessDataResult<List<ProductDetailDTO>>(_productDAL.GetProductDetails());
        }
    }
}
