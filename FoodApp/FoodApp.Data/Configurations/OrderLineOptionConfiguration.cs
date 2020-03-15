using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class OrderLineOptionConfiguration : IEntityTypeConfiguration<OrderLineOption>
    {
        public void Configure(EntityTypeBuilder<OrderLineOption> modelBuilder)
        {
            modelBuilder.ToTable("OrderLineOption");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.OrderLineId).IsRequired();
            modelBuilder.Property(p => p.FoodCustomizationOptionId).IsRequired();
            modelBuilder.Property(p => p.UnitPrice).HasColumnType("decimal(5, 2)").IsRequired();
            modelBuilder.HasOne(x => x.OrderLine).WithMany(x => x.OrderLineOptions);
        }
    }
}

