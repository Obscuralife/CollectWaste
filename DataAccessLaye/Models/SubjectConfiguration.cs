using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models
{
    internal sealed class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectConfiguration()
        {
            ToTable("Subjects");
            HasKey(i => i.Id);
            Property(i => i.Address).HasMaxLength(50).IsRequired();
            Property(i => i.Name).HasMaxLength(50).IsRequired();
            Property(i => i.PhoneNumber).HasMaxLength(50).IsRequired();
            Property(i => i.Email).HasMaxLength(50).IsRequired();
        }
    }
}
