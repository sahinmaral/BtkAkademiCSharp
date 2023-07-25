using PostSharp.Aspects;

using System;
using System.Security;

namespace DevFramework.Core.Aspects.Postsharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation : OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;

            foreach (var role in roles)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(role))
                {
                    isAuthorized = true;
                    break;
                }
            }

            if (!isAuthorized)
            {
                throw new SecurityException("You are not authorized !");
            }

        }
    }
}
