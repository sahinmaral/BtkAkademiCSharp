using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.Entities.ComplexTypes;
using DevFramework.Northwind.Entities.Concrete;

using System.Collections.Generic;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string username, string password)
        {
            return _userDal.Get(u => u.UserName.Equals(username) && u.Password.Equals(password));
        }

        public List<UserRoleDetail> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
