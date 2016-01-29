using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataL.Models.Mapping
{
    public class PermisiuneMap : EntityTypeConfiguration<Permisiune>
    {
        public PermisiuneMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Permisiune1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Permisiune");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Permisiune1).HasColumnName("Permisiune");
        }
    }
}
