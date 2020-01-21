using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models
{
    internal sealed class SolidWasteConfiguration : EntityTypeConfiguration<SolidWaste>
    {
        public SolidWasteConfiguration()
        {
            ToTable("Municipal_Solid_Wastes");
            HasKey(i => i.Id);
        }
    }
}
