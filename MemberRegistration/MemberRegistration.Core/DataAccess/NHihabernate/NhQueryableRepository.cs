using MemberRegistration.Core.Entities;

using NHibernate.Linq;

using System.Linq;

namespace MemberRegistration.Core.DataAccess.NHihabernate
{
    public class NhQueryableRepository<T>:IQueryableRepository<T> where T:class,IEntity,new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;

        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); }
        }
    }
}
