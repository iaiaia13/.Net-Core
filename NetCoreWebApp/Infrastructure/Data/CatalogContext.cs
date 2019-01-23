using ApplicationCore.Entities;
using ApplicationCore.Entities.BasketAggregate;
using ApplicationCore.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Address>(ConfigureAddress);
        }

        //private void ConfigureAddress(EntityTypeBuilder<Address> builder)
        //{
        //    builder.Property(a => a.ZipCode)
        //        .HasMaxLength(18)
        //        .IsRequired();

        //    builder.Property(a => a.Street)
        //        .HasMaxLength(180)
        //        .IsRequired();

        //    builder.Property(a => a.State)
        //        .HasMaxLength(60);

        //    builder.Property(a => a.Country)
        //        .HasMaxLength(90)
        //        .IsRequired();

        //    builder.Property(a => a.City)
        //        .HasMaxLength(100)
        //        .IsRequired();
        //}
    }
}
