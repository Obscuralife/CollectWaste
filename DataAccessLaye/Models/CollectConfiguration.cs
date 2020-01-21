using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models
{
    internal sealed class CollectConfiguration : EntityTypeConfiguration<Collect>
    {
        public CollectConfiguration()
        {
            ToTable("Collect");
            HasKey(i => i.Id);
            HasRequired(i => i.Argument).WithMany(i => i.Collects).HasForeignKey(i => i.ArgumentId).WillCascadeOnDelete(true);
            HasRequired(i => i.SolidWaste).WithMany(i => i.Collects).HasForeignKey(i => i.SolidWasteId).WillCascadeOnDelete(true);
            HasRequired(i => i.Subject).WithMany(i => i.Collects).HasForeignKey(i => i.SubjectId).WillCascadeOnDelete(true);
            HasRequired(i => i.Employe).WithMany(i => i.Collects).HasForeignKey(i => i.EmployeId).WillCascadeOnDelete(true);
            Property(i => i.DateTime).HasColumnName("Date_of_collect").IsRequired();
            Property(i => i.ArgumentId).HasColumnName("Argument_Id").IsRequired();
            Property(i => i.SolidWasteId).HasColumnName("Solid_Waste_Id").IsRequired();
            Property(i => i.SubjectId).HasColumnName("Subject_Id").IsRequired();
            Property(i => i.EmployeId).HasColumnName("Employe_Id").IsRequired();
        }
    }
}
