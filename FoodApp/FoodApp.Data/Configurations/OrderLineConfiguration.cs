using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> modelBuilder)
        {
            modelBuilder.ToTable("OrderLine");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.OrderId).IsRequired();
            modelBuilder.Property(p => p.Quantity).IsRequired();
            modelBuilder.Property(p => p.UnitPrice).HasColumnType("decimal(5, 2)").IsRequired();
            modelBuilder.HasOne(x => x.Order).WithMany(x => x.OrderLines);
        }
    }
}

