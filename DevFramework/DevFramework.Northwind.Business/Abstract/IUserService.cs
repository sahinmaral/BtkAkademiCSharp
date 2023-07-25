using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;

using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string username,string password);
        List<UserRoleDetail> GetUserRoles(User user);
    }
}
