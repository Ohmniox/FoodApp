﻿// <auto-generated />
using System;
using FoodApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodApp.Data.Migrations
{
    [DbContext(typeof(FoodAppDbContext))]
    partial class FoodAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodApp.Entities.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Food");

                    b.HasData(
                        new
                        {
                            Id = new Guid("604ed849-01d3-480d-920c-1135dc3e4ed3"),
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            Name = "Farm House Pizza",
                            UnitPrice = 100.00m
                        },
                        new
                        {
                            Id = new Guid("b8cb83b1-746d-4815-9090-0258b2b3b777"),
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            Name = "Deluxe Veggie Pizza",
                            UnitPrice = 120.00m
                        },
                        new
                        {
                            Id = new Guid("d71be51e-dba1-43a8-b0de-7ea8b7a119f3"),
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            Name = "Green Wave Pizza",
                            UnitPrice = 150.00m
                        },
                        new
                        {
                            Id = new Guid("8fd6797f-a0c4-44d9-83c4-8fb852711650"),
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            Name = "Cheese Grill Sandwich",
                            UnitPrice = 70.00m
                        },
                        new
                        {
                            Id = new Guid("227a1100-dc39-4177-a4af-d3cce82debac"),
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            Name = "Veg Pan Sandwich",
                            UnitPrice = 80.00m
                        },
                        new
                        {
                            Id = new Guid("fdb77ed9-3e0c-484b-a65d-1e286d64937b"),
                            FoodCategoryId = new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"),
                            Name = "Coke",
                            UnitPrice = 20.00m
                        },
                        new
                        {
                            Id = new Guid("ec86a43d-1d51-451a-9882-5bf050e0248c"),
                            FoodCategoryId = new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"),
                            Name = "Maaza",
                            UnitPrice = 20.00m
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.FoodCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("FoodCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            Name = "Sandwiches"
                        },
                        new
                        {
                            Id = new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"),
                            Name = "Drinks"
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.FoodCategoryCustomizationMap", b =>
                {
                    b.Property<Guid>("FoodCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodCustomizationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FoodCategoryId", "FoodCustomizationId");

                    b.HasIndex("FoodCustomizationId");

                    b.ToTable("FoodCategoryCustomization");

                    b.HasData(
                        new
                        {
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            FoodCustomizationId = new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            FoodCustomizationId = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            FoodCustomizationId = new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            FoodCustomizationId = new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            FoodCustomizationId = new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            FoodCustomizationId = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            FoodCustomizationId = new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            FoodCustomizationId = new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4")
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.FoodCustomization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CanSelectMultipleOptions")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("FoodCustomization");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"),
                            CanSelectMultipleOptions = false,
                            Name = "Pizza Base"
                        },
                        new
                        {
                            Id = new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"),
                            CanSelectMultipleOptions = false,
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"),
                            CanSelectMultipleOptions = true,
                            Name = "Toppings"
                        },
                        new
                        {
                            Id = new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"),
                            CanSelectMultipleOptions = true,
                            Name = "Cheese Options"
                        },
                        new
                        {
                            Id = new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"),
                            CanSelectMultipleOptions = true,
                            Name = "Sauces"
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.FoodCustomizationOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodCustomizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("Id");

                    b.HasIndex("FoodCustomizationId");

                    b.ToTable("FoodCustomizationOption");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ba0f5eb-646b-4af0-96c7-e914eb83dd3c"),
                            FoodCustomizationId = new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"),
                            Name = "Hand Tossed",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("81c1439f-4862-4aba-a1ef-c7fdf5eda2e0"),
                            FoodCustomizationId = new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"),
                            Name = "Fresh Pan",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("446eb183-db6d-4ac6-a77a-e40b70c0e774"),
                            FoodCustomizationId = new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"),
                            Name = "Thin Crust",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("0eeaba91-286b-4082-a7a4-162bb4bab564"),
                            FoodCustomizationId = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"),
                            Name = "Black Olive",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("70d9ad31-a8af-4976-b055-5cf2fcdacd14"),
                            FoodCustomizationId = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"),
                            Name = "Red Paprika",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("108ee6a9-60b8-454e-8b88-b5728f3290cc"),
                            FoodCustomizationId = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"),
                            Name = "Golden Corn",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("87cce679-0a3c-4efe-94f5-d4f94e1fb6f9"),
                            FoodCustomizationId = new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"),
                            Name = "Panner",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("d0b51320-e31b-478b-9461-7dc17862ed12"),
                            FoodCustomizationId = new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"),
                            Name = "Mozzarella",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("78ee0259-5585-4284-814d-c036f7c694c7"),
                            FoodCustomizationId = new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"),
                            Name = "Cheddar",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("db7cee3d-e034-4cff-b6f7-ecc7011fbf73"),
                            FoodCustomizationId = new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"),
                            Name = "Barbeque",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("483271ed-ed31-46a6-9cf2-7f47dd5ca9dd"),
                            FoodCustomizationId = new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"),
                            Name = "Honey Mustard",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("298c9a95-7fd6-45d8-9ad3-60ff92a98223"),
                            FoodCustomizationId = new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"),
                            Name = "Southwest",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("eba6ff86-02d2-4356-9901-fc583e52b074"),
                            FoodCustomizationId = new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"),
                            Name = "Multi grain",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("bb5d3c34-28d4-4bed-8930-05bb48d60bc4"),
                            FoodCustomizationId = new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"),
                            Name = "Oat",
                            UnitPrice = 10m
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Restaurant");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e416791b-0a71-42da-8e59-e8b16763ce16"),
                            Name = "McD"
                        },
                        new
                        {
                            Id = new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051"),
                            Name = "Pizza Hut"
                        },
                        new
                        {
                            Id = new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd"),
                            Name = "Sandwich Express"
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.RestaurantFoodCategoryMap", b =>
                {
                    b.Property<Guid>("FoodCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FoodCategoryId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantFoodCategoryMap");

                    b.HasData(
                        new
                        {
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            RestaurantId = new Guid("e416791b-0a71-42da-8e59-e8b16763ce16")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            RestaurantId = new Guid("e416791b-0a71-42da-8e59-e8b16763ce16")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"),
                            RestaurantId = new Guid("e416791b-0a71-42da-8e59-e8b16763ce16")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"),
                            RestaurantId = new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"),
                            RestaurantId = new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("17520549-f179-48e7-8a08-34c86e2571f8"),
                            RestaurantId = new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"),
                            RestaurantId = new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd")
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7239b67e-35e1-49a2-be04-08accc493a4f"),
                            Email = "admin@foodapp.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            PasswordHash = "$2a$11$cJh8vjqPHj/xnIlHHRSUJuPDRlKJhtUokO9qQn8w/u8AgHNKTKdSS",
                            UserType = 1
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.Food", b =>
                {
                    b.HasOne("FoodApp.Entities.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodApp.Entities.FoodCategoryCustomizationMap", b =>
                {
                    b.HasOne("FoodApp.Entities.FoodCategory", "FoodCategory")
                        .WithMany("FoodCategoryCustomizationMaps")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodApp.Entities.FoodCustomization", "FoodCustomization")
                        .WithMany("FoodCategoryCustomizationMaps")
                        .HasForeignKey("FoodCustomizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodApp.Entities.FoodCustomizationOption", b =>
                {
                    b.HasOne("FoodApp.Entities.FoodCustomization", "FoodCustomization")
                        .WithMany("FoodCustomizationOptions")
                        .HasForeignKey("FoodCustomizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodApp.Entities.RestaurantFoodCategoryMap", b =>
                {
                    b.HasOne("FoodApp.Entities.FoodCategory", "FoodCategory")
                        .WithMany("RestaurantFoodCategoryMaps")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodApp.Entities.Restaurant", "Restaurant")
                        .WithMany("RestaurantFoodCategoryMaps")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
