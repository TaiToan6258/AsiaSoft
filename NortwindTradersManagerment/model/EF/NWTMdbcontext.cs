using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace model.EF
{
    public partial class NWTMdbcontext : DbContext
    {
        public NWTMdbcontext()
            : base("name=NWTMdbcontext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalAmount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);
        }
    }
}
