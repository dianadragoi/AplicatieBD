using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataL.Models.Mapping
{
    public class IntrebariMap : EntityTypeConfiguration<Intrebari>
    {
        public IntrebariMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Intrebare)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Intrebari");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Intrebare).HasColumnName("Intrebare");
            this.Property(t => t.ID_materie).HasColumnName("ID_materie");

            // Relationships
            this.HasRequired(t => t.Materii)
                .WithMany(t => t.Intrebaris)
                .HasForeignKey(d => d.ID_materie);

        }
    }
}
