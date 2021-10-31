using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using FluentValidation;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _productDal.GetAll(filter);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(),product);

            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            try
            {
                _productDal.Update(product);
            }
            catch (DbUpdateException exception)
            {
                throw new DbUpdateException("Güncelleme gerçekleşemedi");
            }
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException exception)
            {
                throw new DbUpdateException("Silme gerçekleşemedi");
            }
            
        }
    }
}
