using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models
{
    internal sealed class ArgumentConfiguration : EntityTypeConfiguration<Argument>
    {
        public ArgumentConfiguration()
        {
            ToTable("Arguments");
            HasKey(i => i.Id);
            Property(i => i.Description).HasColumnName("Argument_Description").IsRequired();
        }
    }
}
