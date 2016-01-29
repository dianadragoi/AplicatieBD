using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BussinessL.Models.Mapping
{
    public class RoluriMap : EntityTypeConfiguration<Roluri>
    {
        public RoluriMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Rol)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Roluri");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Rol).HasColumnName("Rol");
        }
    }
}
