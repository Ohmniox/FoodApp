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
                            Id = new Guid("4ceac9e8-b608-46c8-be4e-ca55498a713c"),
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            Name = "Farm House Pizza",
                            UnitPrice = 100.00m
                        },
                        new
                        {
                            Id = new Guid("0f0e2fb7-aa7f-481a-93d7-47dbb90131f6"),
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            Name = "Deluxe Veggie Pizza",
                            UnitPrice = 120.00m
                        },
                        new
                        {
                            Id = new Guid("b44ed525-47d4-43db-a8f5-b63b69e4fe3e"),
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            Name = "Green Wave Pizza",
                            UnitPrice = 150.00m
                        },
                        new
                        {
                            Id = new Guid("17cfa138-d271-41da-a4f7-7f59c0c6f7f1"),
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            Name = "Cheese Grill Sandwich",
                            UnitPrice = 70.00m
                        },
                        new
                        {
                            Id = new Guid("03b3bc5c-2bbd-4b1f-a037-20122c458870"),
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            Name = "Veg Pan Sandwich",
                            UnitPrice = 80.00m
                        },
                        new
                        {
                            Id = new Guid("73cd3158-e6bb-4a87-b538-e5d0d618803a"),
                            FoodCategoryId = new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"),
                            Name = "Coke",
                            UnitPrice = 20.00m
                        },
                        new
                        {
                            Id = new Guid("63e72884-9b49-48c1-862b-e88da3778c36"),
                            FoodCategoryId = new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"),
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
                            Id = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            Name = "Sandwiches"
                        },
                        new
                        {
                            Id = new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"),
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
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            FoodCustomizationId = new Guid("934892e8-e681-423e-aea4-5aceb08f1924")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            FoodCustomizationId = new Guid("b57fb321-2a94-4348-854c-46c11e357687")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            FoodCustomizationId = new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            FoodCustomizationId = new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            FoodCustomizationId = new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            FoodCustomizationId = new Guid("b57fb321-2a94-4348-854c-46c11e357687")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            FoodCustomizationId = new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            FoodCustomizationId = new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a")
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
                            Id = new Guid("934892e8-e681-423e-aea4-5aceb08f1924"),
                            CanSelectMultipleOptions = false,
                            Name = "Pizza Base"
                        },
                        new
                        {
                            Id = new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"),
                            CanSelectMultipleOptions = false,
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("b57fb321-2a94-4348-854c-46c11e357687"),
                            CanSelectMultipleOptions = true,
                            Name = "Toppings"
                        },
                        new
                        {
                            Id = new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"),
                            CanSelectMultipleOptions = true,
                            Name = "Cheese Options"
                        },
                        new
                        {
                            Id = new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"),
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
                            Id = new Guid("bb040886-7243-446c-ad41-8affd6f06c3d"),
                            FoodCustomizationId = new Guid("934892e8-e681-423e-aea4-5aceb08f1924"),
                            Name = "Hand Tossed",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("901e02b5-49ab-4213-8395-d9a8907ca9f5"),
                            FoodCustomizationId = new Guid("934892e8-e681-423e-aea4-5aceb08f1924"),
                            Name = "Fresh Pan",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("9a23f518-f226-4ca7-8fd6-268f9c3bf61e"),
                            FoodCustomizationId = new Guid("934892e8-e681-423e-aea4-5aceb08f1924"),
                            Name = "Thin Crust",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("263269ed-b5d7-4dc6-9e94-c880d872ec84"),
                            FoodCustomizationId = new Guid("b57fb321-2a94-4348-854c-46c11e357687"),
                            Name = "Black Olive",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("6ff43eaf-0eb1-414e-9c50-827693f390f8"),
                            FoodCustomizationId = new Guid("b57fb321-2a94-4348-854c-46c11e357687"),
                            Name = "Red Paprika",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("5d71c087-480f-454f-8ada-35da547a9615"),
                            FoodCustomizationId = new Guid("b57fb321-2a94-4348-854c-46c11e357687"),
                            Name = "Golden Corn",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("d6f42205-9745-4189-98eb-a4381425bd23"),
                            FoodCustomizationId = new Guid("b57fb321-2a94-4348-854c-46c11e357687"),
                            Name = "Panner",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("733795d2-262e-4704-9812-1142ce97bf0b"),
                            FoodCustomizationId = new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"),
                            Name = "Mozzarella",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("7724d404-74bc-4899-8252-852e8c71beb7"),
                            FoodCustomizationId = new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"),
                            Name = "Cheddar",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("9343a562-4661-4c25-981d-a135290587dc"),
                            FoodCustomizationId = new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"),
                            Name = "Barbeque",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("59b32340-f361-42f8-9db7-d2ff5717f930"),
                            FoodCustomizationId = new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"),
                            Name = "Honey Mustard",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("e2cf48b0-029b-4749-a199-844a3fc71308"),
                            FoodCustomizationId = new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"),
                            Name = "Southwest",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("1670990e-0b12-405d-aa10-9765dff0132e"),
                            FoodCustomizationId = new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"),
                            Name = "Multi grain",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("e7d47d1a-3258-4ed4-be76-9224bf8538ef"),
                            FoodCustomizationId = new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"),
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
                            Id = new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d"),
                            Name = "McD"
                        },
                        new
                        {
                            Id = new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9"),
                            Name = "Pizza Hut"
                        },
                        new
                        {
                            Id = new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82"),
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
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            RestaurantId = new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            RestaurantId = new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"),
                            RestaurantId = new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("5a7a32ad-b119-4117-a672-9b037f809438"),
                            RestaurantId = new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"),
                            RestaurantId = new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"),
                            RestaurantId = new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"),
                            RestaurantId = new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82")
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
