using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolvers.Ninject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace DevFramework.Northwind.WebApi.MessageHandlers
{
    public class AuthenticationHandler : DelegatingHandler
    {

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                var token = request.Headers.GetValues("Authorization").FirstOrDefault();
                if(token != null)
                {
                    IUserService _userService = InstanceFactory.GetInstance<IUserService>();

                    byte[] data = Convert.FromBase64String(token);
                    string decodedString = Encoding.UTF8.GetString(data);

                    string[] tokenValues = decodedString.Split(':');

                    string username = tokenValues[0];
                    string password = tokenValues[1];

                    var user = _userService.GetByUserNameAndPassword(username, password);

                    if (user != null)
                    {
                        IPrincipal principal = new GenericPrincipal(
                            new GenericIdentity(username),
                            _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray()
                            );

                        Thread.CurrentPrincipal = principal;
                        HttpContext.Current.User = principal;
                    }
                }
            }
            catch
            {
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}