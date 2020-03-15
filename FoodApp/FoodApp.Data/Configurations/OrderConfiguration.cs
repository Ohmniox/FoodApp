using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> modelBuilder)
        {
            modelBuilder.ToTable("Order");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.RestaurantId).IsRequired();
            modelBuilder.Property(p => p.UserId).IsRequired();
            modelBuilder.Property(p => p.TotalAmount).HasColumnType("decimal(7, 2)").IsRequired();
        }
    }
}

