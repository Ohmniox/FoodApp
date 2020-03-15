﻿// <auto-generated />
using System;
using FoodApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodApp.Data.Migrations
{
    [DbContext(typeof(FoodAppDbContext))]
    [Migration("20200315070511_AddedOrderEntities")]
    partial class AddedOrderEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("6812e44b-136e-4c90-8c8f-19a8755227b9"),
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            Name = "Farm House Pizza",
                            UnitPrice = 100.00m
                        },
                        new
                        {
                            Id = new Guid("95bb4d6c-6642-4874-a4fb-9c89c0fad96f"),
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            Name = "Deluxe Veggie Pizza",
                            UnitPrice = 120.00m
                        },
                        new
                        {
                            Id = new Guid("3479ce8f-ad14-43f1-89e2-305e0ec9d7d1"),
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            Name = "Green Wave Pizza",
                            UnitPrice = 150.00m
                        },
                        new
                        {
                            Id = new Guid("ae2adadb-c7c9-431b-bebe-0fb5696aec5c"),
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            Name = "Cheese Grill Sandwich",
                            UnitPrice = 70.00m
                        },
                        new
                        {
                            Id = new Guid("01de8efa-b104-4f4c-a06e-1aeac87a058d"),
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            Name = "Veg Pan Sandwich",
                            UnitPrice = 80.00m
                        },
                        new
                        {
                            Id = new Guid("f8b743b5-4ac4-4fd9-8d61-9d3f230752bb"),
                            FoodCategoryId = new Guid("37706f0a-5309-4820-8529-33e98590f532"),
                            Name = "Coke",
                            UnitPrice = 20.00m
                        },
                        new
                        {
                            Id = new Guid("13ad8c09-3a52-439b-b5cf-7e45cb73a93d"),
                            FoodCategoryId = new Guid("37706f0a-5309-4820-8529-33e98590f532"),
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
                            Id = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            Name = "Sandwiches"
                        },
                        new
                        {
                            Id = new Guid("37706f0a-5309-4820-8529-33e98590f532"),
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
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            FoodCustomizationId = new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            FoodCustomizationId = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            FoodCustomizationId = new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            FoodCustomizationId = new Guid("515da683-6caf-473f-9f17-17aa50021d82")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            FoodCustomizationId = new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            FoodCustomizationId = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            FoodCustomizationId = new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            FoodCustomizationId = new Guid("515da683-6caf-473f-9f17-17aa50021d82")
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
                            Id = new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"),
                            CanSelectMultipleOptions = false,
                            Name = "Pizza Base"
                        },
                        new
                        {
                            Id = new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"),
                            CanSelectMultipleOptions = false,
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"),
                            CanSelectMultipleOptions = true,
                            Name = "Toppings"
                        },
                        new
                        {
                            Id = new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"),
                            CanSelectMultipleOptions = true,
                            Name = "Cheese Options"
                        },
                        new
                        {
                            Id = new Guid("515da683-6caf-473f-9f17-17aa50021d82"),
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
                            Id = new Guid("ced57abc-d59a-4a55-9395-213ac61acf49"),
                            FoodCustomizationId = new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"),
                            Name = "Hand Tossed",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("254e6270-854c-4976-8f3e-f91efc35189d"),
                            FoodCustomizationId = new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"),
                            Name = "Fresh Pan",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("e81fdd73-78e8-4836-8030-6b57b440360a"),
                            FoodCustomizationId = new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"),
                            Name = "Thin Crust",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("590c3ece-daa1-406a-a324-b2571d47edfa"),
                            FoodCustomizationId = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"),
                            Name = "Black Olive",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("c3a0fadd-3a2d-4244-8bc9-166f837bc943"),
                            FoodCustomizationId = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"),
                            Name = "Red Paprika",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("eff92807-35c0-4d4e-a677-b11bae3acb38"),
                            FoodCustomizationId = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"),
                            Name = "Golden Corn",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("b090ee10-6214-46fb-b6b4-ae0425200af5"),
                            FoodCustomizationId = new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"),
                            Name = "Panner",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("d92b9add-a74b-4959-8acd-3833863838ec"),
                            FoodCustomizationId = new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"),
                            Name = "Mozzarella",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("e743e020-9b3c-4e3b-961e-c99ede8967fb"),
                            FoodCustomizationId = new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"),
                            Name = "Cheddar",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("7c202c73-cdf7-4c96-88ed-03f7a66de8f3"),
                            FoodCustomizationId = new Guid("515da683-6caf-473f-9f17-17aa50021d82"),
                            Name = "Barbeque",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("407d019d-2b50-4d3d-aff2-37d19d5c13f3"),
                            FoodCustomizationId = new Guid("515da683-6caf-473f-9f17-17aa50021d82"),
                            Name = "Honey Mustard",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("391f0017-9c03-4a04-9640-d2adcc485995"),
                            FoodCustomizationId = new Guid("515da683-6caf-473f-9f17-17aa50021d82"),
                            Name = "Southwest",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("65754491-842f-4116-9461-5b945a07ac5c"),
                            FoodCustomizationId = new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"),
                            Name = "Multi grain",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("763d6ae6-6bb6-43fb-b7ef-a16b3ba6bf29"),
                            FoodCustomizationId = new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"),
                            Name = "Oat",
                            UnitPrice = 10m
                        });
                });

            modelBuilder.Entity("FoodApp.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(7, 2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FoodApp.Entities.OrderLine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLine");
                });

            modelBuilder.Entity("FoodApp.Entities.OrderLineOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodCustomizationOptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderLineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderLineId");

                    b.ToTable("OrderLineOption");
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
                            Id = new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e"),
                            Name = "McD"
                        },
                        new
                        {
                            Id = new Guid("b94f227b-1865-4850-8556-876a03bb6a92"),
                            Name = "Pizza Hut"
                        },
                        new
                        {
                            Id = new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7"),
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
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            RestaurantId = new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            RestaurantId = new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("37706f0a-5309-4820-8529-33e98590f532"),
                            RestaurantId = new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"),
                            RestaurantId = new Guid("b94f227b-1865-4850-8556-876a03bb6a92")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("37706f0a-5309-4820-8529-33e98590f532"),
                            RestaurantId = new Guid("b94f227b-1865-4850-8556-876a03bb6a92")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"),
                            RestaurantId = new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("37706f0a-5309-4820-8529-33e98590f532"),
                            RestaurantId = new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7")
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
                            Id = new Guid("6cbca69d-e9a1-4896-a1b3-35205f86a3b0"),
                            Email = "admin@foodapp.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            PasswordHash = "$2a$11$gkBFRKDn7v8xUicttBIfkOZ/NinK7NdB9Zl.Xd0bfh9laaXO4bhP6",
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

            modelBuilder.Entity("FoodApp.Entities.OrderLine", b =>
                {
                    b.HasOne("FoodApp.Entities.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodApp.Entities.OrderLineOption", b =>
                {
                    b.HasOne("FoodApp.Entities.OrderLine", "OrderLine")
                        .WithMany("OrderLineOptions")
                        .HasForeignKey("OrderLineId")
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
