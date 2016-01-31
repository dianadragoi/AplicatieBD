using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataL.Models.Mapping;

namespace DataL.Models
{
    public partial class ProiectContext : DbContext
    {
        static ProiectContext()
        {
            Database.SetInitializer<ProiectContext>(null);
        }

        public ProiectContext()
            : base(@"Data Source=RADU-PC\RADU;Initial Catalog=Proiect;Integrated Security=SSPI")
        {
        }

        public DbSet<Intrebari> Intrebaris { get; set; }
        public DbSet<Materii> Materiis { get; set; }
        public DbSet<Permisiune> Permisiunes { get; set; }
        public DbSet<Raspunsuri> Raspunsuris { get; set; }
        public DbSet<Roluri> Roluris { get; set; }
        public DbSet<Roluri_Permisiuni> Roluri_Permisiuni { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IntrebariMap());
            modelBuilder.Configurations.Add(new MateriiMap());
            modelBuilder.Configurations.Add(new PermisiuneMap());
            modelBuilder.Configurations.Add(new RaspunsuriMap());
            modelBuilder.Configurations.Add(new RoluriMap());
            modelBuilder.Configurations.Add(new Roluri_PermisiuniMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
