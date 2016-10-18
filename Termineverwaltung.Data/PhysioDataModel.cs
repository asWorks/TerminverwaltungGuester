using System.Data.Entity.ModelConfiguration.Conventions;

namespace Termineverwaltung.Data
{
    using System.Data.Entity;

    public partial class PhysioDataModel : DbContext
    {
        public PhysioDataModel()
            : base("name=PhysioDataContext")
        {
        }

        public virtual DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public virtual DbSet<Patiententermin> Termine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Mitarbeiter>()
                .Property(e => e.Nachname)
                .IsUnicode(false);

            modelBuilder.Entity<Mitarbeiter>()
                .Property(e => e.Vorname)
                .IsUnicode(false);
        }
    }
}
