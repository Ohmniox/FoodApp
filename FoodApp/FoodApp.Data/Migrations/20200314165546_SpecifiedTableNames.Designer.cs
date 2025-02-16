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
    [Migration("20200314165546_SpecifiedTableNames")]
    partial class SpecifiedTableNames
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
                            Id = new Guid("32181804-9ac7-4075-a94b-8682e689359b"),
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            Name = "Farm House Pizza",
                            UnitPrice = 100.00m
                        },
                        new
                        {
                            Id = new Guid("7d0ba04d-0372-4ecb-82e5-2c5f450a3514"),
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            Name = "Deluxe Veggie Pizza",
                            UnitPrice = 120.00m
                        },
                        new
                        {
                            Id = new Guid("41e46d0d-fc48-4cb0-a04a-b920ec274047"),
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            Name = "Green Wave Pizza",
                            UnitPrice = 150.00m
                        },
                        new
                        {
                            Id = new Guid("5f8342b0-7281-4e86-8a8a-f7825c97d992"),
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            Name = "Cheese Grill Sandwich",
                            UnitPrice = 70.00m
                        },
                        new
                        {
                            Id = new Guid("3c08fd06-f79e-4c5f-8a8f-8ef965388c43"),
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            Name = "Veg Pan Sandwich",
                            UnitPrice = 80.00m
                        },
                        new
                        {
                            Id = new Guid("c0629967-dd13-40cf-a1b6-5fd11d12441f"),
                            FoodCategoryId = new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"),
                            Name = "Coke",
                            UnitPrice = 20.00m
                        },
                        new
                        {
                            Id = new Guid("9a5cd69b-8052-4873-9e38-ef5c34f017af"),
                            FoodCategoryId = new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"),
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
                            Id = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            Name = "Sandwiches"
                        },
                        new
                        {
                            Id = new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"),
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
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            FoodCustomizationId = new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            FoodCustomizationId = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            FoodCustomizationId = new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            FoodCustomizationId = new Guid("29418ebf-edd5-47da-b716-c108b102a49e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            FoodCustomizationId = new Guid("ee47dd18-9327-417f-92a6-45f41003e89b")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            FoodCustomizationId = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            FoodCustomizationId = new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            FoodCustomizationId = new Guid("29418ebf-edd5-47da-b716-c108b102a49e")
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
                            Id = new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"),
                            CanSelectMultipleOptions = false,
                            Name = "Pizza Base"
                        },
                        new
                        {
                            Id = new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"),
                            CanSelectMultipleOptions = false,
                            Name = "Bread"
                        },
                        new
                        {
                            Id = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"),
                            CanSelectMultipleOptions = true,
                            Name = "Toppings"
                        },
                        new
                        {
                            Id = new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"),
                            CanSelectMultipleOptions = true,
                            Name = "Cheese Options"
                        },
                        new
                        {
                            Id = new Guid("29418ebf-edd5-47da-b716-c108b102a49e"),
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
                            Id = new Guid("941876df-dbb2-4883-8a90-394f395e6734"),
                            FoodCustomizationId = new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"),
                            Name = "Hand Tossed",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("d9781947-135a-482a-8575-892002a05482"),
                            FoodCustomizationId = new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"),
                            Name = "Fresh Pan",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("25f521a6-446b-4568-b8d6-1648ba7efd14"),
                            FoodCustomizationId = new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"),
                            Name = "Thin Crust",
                            UnitPrice = 50m
                        },
                        new
                        {
                            Id = new Guid("d83d8ca1-86cd-4a8e-bd97-b86a8cb8314f"),
                            FoodCustomizationId = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"),
                            Name = "Black Olive",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("63669850-7192-4a00-afbf-c224b552c6a2"),
                            FoodCustomizationId = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"),
                            Name = "Red Paprika",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("ff66f592-ea64-4ebc-bbce-baac647d2de0"),
                            FoodCustomizationId = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"),
                            Name = "Golden Corn",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("4ce749b4-6007-4eee-b9aa-8d84bb6f51fb"),
                            FoodCustomizationId = new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"),
                            Name = "Panner",
                            UnitPrice = 20m
                        },
                        new
                        {
                            Id = new Guid("803bb2ff-b5aa-4926-9c78-04ca7969c879"),
                            FoodCustomizationId = new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"),
                            Name = "Mozzarella",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("c9885167-2af3-4fb3-a33c-27ebf2f19797"),
                            FoodCustomizationId = new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"),
                            Name = "Cheddar",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("5f62379f-9da1-43e3-b979-7dd0a6f60e42"),
                            FoodCustomizationId = new Guid("29418ebf-edd5-47da-b716-c108b102a49e"),
                            Name = "Barbeque",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("f4433799-dfab-42d5-b768-1f1a452497af"),
                            FoodCustomizationId = new Guid("29418ebf-edd5-47da-b716-c108b102a49e"),
                            Name = "Honey Mustard",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("65848a9d-b600-49b6-b39e-e93ea45219d7"),
                            FoodCustomizationId = new Guid("29418ebf-edd5-47da-b716-c108b102a49e"),
                            Name = "Southwest",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("b8ef553c-940a-4912-a1a5-73a2e52cb6dc"),
                            FoodCustomizationId = new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"),
                            Name = "Multi grain",
                            UnitPrice = 10m
                        },
                        new
                        {
                            Id = new Guid("327ae44a-805e-4b7a-a722-1281cc05ac93"),
                            FoodCustomizationId = new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"),
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
                            Id = new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e"),
                            Name = "McD"
                        },
                        new
                        {
                            Id = new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8"),
                            Name = "Pizza Hut"
                        },
                        new
                        {
                            Id = new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c"),
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
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            RestaurantId = new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            RestaurantId = new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"),
                            RestaurantId = new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"),
                            RestaurantId = new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"),
                            RestaurantId = new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"),
                            RestaurantId = new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c")
                        },
                        new
                        {
                            FoodCategoryId = new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"),
                            RestaurantId = new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c")
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
