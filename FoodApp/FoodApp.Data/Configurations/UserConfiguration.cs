using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.ToTable("User");
            modelBuilder.HasKey(k => k.Id);
            modelBuilder.Property(p => p.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Property(p => p.PasswordHash).IsRequired();
            modelBuilder.Property(p => p.UserType).IsRequired();
        }
    }
}

