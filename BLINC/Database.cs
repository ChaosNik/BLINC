namespace BLINC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Linija> Linija { get; set; }
        public virtual DbSet<Polazak> Polazak { get; set; }
        public virtual DbSet<Stajaliste> Stajaliste { get; set; }
        public virtual DbSet<StajalisteLinije> StajalisteLinije { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Lozinka)
                .IsFixedLength();

            modelBuilder.Entity<Linija>()
                .HasMany(e => e.Polazak)
                .WithOptional(e => e.Linija1)
                .HasForeignKey(e => e.Linija);

            modelBuilder.Entity<Linija>()
                .HasMany(e => e.StajalisteLinije)
                .WithOptional(e => e.Linija1)
                .HasForeignKey(e => e.Linija);

            modelBuilder.Entity<Polazak>()
                .Property(e => e.Vrijeme)
                .HasPrecision(0);

            modelBuilder.Entity<Stajaliste>()
                .HasMany(e => e.StajalisteLinije)
                .WithOptional(e => e.Stajaliste1)
                .HasForeignKey(e => e.Stajaliste);
        }
    }
}
