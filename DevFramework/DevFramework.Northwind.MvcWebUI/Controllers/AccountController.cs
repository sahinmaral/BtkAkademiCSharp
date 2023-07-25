using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using DevFramework.Northwind.Business.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public string Login(string username,string password)
        {
            var user = _userService.GetByUserNameAndPassword(username,password);

            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    id: Guid.NewGuid(),
                    userName: user.UserName,
                    email: user.Email,
                    expiration: DateTime.Now.AddMinutes(15),
                    roles: _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(),
                    rememberMe: false,
                    firstName: user.FirstName,
                    lastName: user.LastName
                );

                return "User is authenticated";
            }

            return "User is not authenticated";

        }
    }
}