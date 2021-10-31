using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
    }
}
