using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BussinessL.Models.Mapping
{
    public class RaspunsuriMap : EntityTypeConfiguration<Raspunsuri>
    {
        public RaspunsuriMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID_intrebare, t.Var_raspuns, t.Corect });

            // Properties
            this.Property(t => t.ID_intrebare)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Var_raspuns)
                .IsRequired();

            this.Property(t => t.Corect)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Raspunsuri");
            this.Property(t => t.ID_intrebare).HasColumnName("ID_intrebare");
            this.Property(t => t.Var_raspuns).HasColumnName("Var_raspuns");
            this.Property(t => t.Corect).HasColumnName("Corect");

            // Relationships
            this.HasRequired(t => t.Intrebari)
                .WithMany(t => t.Raspunsuris)
                .HasForeignKey(d => d.ID_intrebare);

        }
    }
}
