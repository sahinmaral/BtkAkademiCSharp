using MemberRegistration.DataAccess.Concrete.EntityFramework.Mappings;
using MemberRegistration.Entities.Concrete;

using System.Data.Entity;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class MembershipContext:DbContext
    {
        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(MemberMap).Assembly);
        }
    }
}
