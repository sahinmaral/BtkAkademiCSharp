using FluentValidation;

using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.Entities.Concrete;

using Ninject.Modules;

namespace MemberRegistration.Business.DependencyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
