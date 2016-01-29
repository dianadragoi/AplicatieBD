using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataL.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired();

            this.Property(t => t.Username)
                .IsRequired();

            this.Property(t => t.Parola)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Nume).HasColumnName("Nume");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.ID_rol).HasColumnName("ID_rol");
            this.Property(t => t.ID_materie).HasColumnName("ID_materie");

            // Relationships
            this.HasOptional(t => t.Materii)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.ID_materie);
            this.HasRequired(t => t.Roluri)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.ID_rol);

        }
    }
}
