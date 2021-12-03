namespace Верфь
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Boats> Boats { get; set; }
        public virtual DbSet<BoatType> BoatType { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WoodType> WoodType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boats>()
                .Property(e => e.BasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Boats>()
                .Property(e => e.WAT)
                .HasPrecision(2, 2);

            modelBuilder.Entity<BoatType>()
                .HasMany(e => e.Boats)
                .WithRequired(e => e.BoatType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contracts>()
                .Property(e => e.DepositPayed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contracts>()
                .Property(e => e.ContractTotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contracts>()
                .Property(e => e.ContractTotalPriceInclVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contracts>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Contracts)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.SumInclVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .WillCascadeOnDelete(false);
        }
    }
}
