using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models
{
    internal sealed class EmployeConfiguration: EntityTypeConfiguration<Employe>
    {
        public EmployeConfiguration()
        {
            ToTable("Employes");
            HasKey(i => i.Id);
            Property(i => i.Login).IsRequired();
            Property(i => i.Name).IsRequired();
            Property(i => i.Password).HasMaxLength(50).IsRequired();
            Property(i => i.PhoneNumber).IsRequired();
            Property(i => i.Position).HasMaxLength(50).IsRequired();
            Property(i => i.Address).IsRequired();
        }
    }
}
