using MemberRegistration.Core.Entities;

using System.Linq;

namespace MemberRegistration.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class ,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
