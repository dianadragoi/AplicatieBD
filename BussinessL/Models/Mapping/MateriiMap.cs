using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BussinessL.Models.Mapping
{
    public class MateriiMap : EntityTypeConfiguration<Materii>
    {
        public MateriiMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Materii");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.materie).HasColumnName("materie");
        }
    }
}
