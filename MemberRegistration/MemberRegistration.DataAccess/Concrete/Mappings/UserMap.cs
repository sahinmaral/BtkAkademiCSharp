using MemberRegistration.Entities.Concrete;

using System.Data.Entity.ModelConfiguration;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            ToTable(@"Members", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.TCNo).HasColumnName("TCNo");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
        }
    }
}
