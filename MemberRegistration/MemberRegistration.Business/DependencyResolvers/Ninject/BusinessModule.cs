using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Core.DataAccess;
using MemberRegistration.Core.DataAccess.EntityFramework;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.DataAccess.Concrete.EntityFramework;

using Ninject.Modules;

using System.Data.Entity;

namespace MemberRegistration.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();

            Bind<IKPSService>().To<KPSServiceAdapter>().InSingletonScope();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<MembershipContext>();
        }
    }
}
