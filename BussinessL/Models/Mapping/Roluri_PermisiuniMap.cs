using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BussinessL.Models.Mapping
{
    public class Roluri_PermisiuniMap : EntityTypeConfiguration<Roluri_Permisiuni>
    {
        public Roluri_PermisiuniMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Roluri_Permisiuni");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ID_rol).HasColumnName("ID_rol");
            this.Property(t => t.ID_permisiune).HasColumnName("ID_permisiune");

            // Relationships
            this.HasRequired(t => t.Permisiune)
                .WithMany(t => t.Roluri_Permisiuni)
                .HasForeignKey(d => d.ID_permisiune);
            this.HasRequired(t => t.Roluri)
                .WithMany(t => t.Roluri_Permisiuni)
                .HasForeignKey(d => d.ID_rol);

        }
    }
}
