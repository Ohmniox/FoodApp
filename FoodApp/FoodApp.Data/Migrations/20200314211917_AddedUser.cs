using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodApp.Data.Migrations
{
    public partial class AddedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("32181804-9ac7-4075-a94b-8682e689359b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3c08fd06-f79e-4c5f-8a8f-8ef965388c43"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("41e46d0d-fc48-4cb0-a04a-b920ec274047"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5f8342b0-7281-4e86-8a8a-f7825c97d992"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7d0ba04d-0372-4ecb-82e5-2c5f450a3514"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("9a5cd69b-8052-4873-9e38-ef5c34f017af"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c0629967-dd13-40cf-a1b6-5fd11d12441f"));

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("ee47dd18-9327-417f-92a6-45f41003e89b") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b") });

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("25f521a6-446b-4568-b8d6-1648ba7efd14"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("327ae44a-805e-4b7a-a722-1281cc05ac93"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("4ce749b4-6007-4eee-b9aa-8d84bb6f51fb"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("5f62379f-9da1-43e3-b979-7dd0a6f60e42"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("63669850-7192-4a00-afbf-c224b552c6a2"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("65848a9d-b600-49b6-b39e-e93ea45219d7"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("803bb2ff-b5aa-4926-9c78-04ca7969c879"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("941876df-dbb2-4883-8a90-394f395e6734"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("b8ef553c-940a-4912-a1a5-73a2e52cb6dc"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("c9885167-2af3-4fb3-a33c-27ebf2f19797"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("d83d8ca1-86cd-4a8e-bd97-b86a8cb8314f"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("d9781947-135a-482a-8575-892002a05482"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("f4433799-dfab-42d5-b768-1f1a452497af"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("ff66f592-ea64-4ebc-bbce-baac647d2de0"));

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8") });

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("29418ebf-edd5-47da-b716-c108b102a49e"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8"));

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), "Pizza" },
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), "Sandwiches" },
                    { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomization",
                columns: new[] { "Id", "CanSelectMultipleOptions", "Name" },
                values: new object[,]
                {
                    { new Guid("934892e8-e681-423e-aea4-5aceb08f1924"), false, "Pizza Base" },
                    { new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"), false, "Bread" },
                    { new Guid("b57fb321-2a94-4348-854c-46c11e357687"), true, "Toppings" },
                    { new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"), true, "Cheese Options" },
                    { new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"), true, "Sauces" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d"), "McD" },
                    { new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9"), "Pizza Hut" },
                    { new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82"), "Sandwich Express" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "FoodCategoryId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("4ceac9e8-b608-46c8-be4e-ca55498a713c"), new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), "Farm House Pizza", 100.00m },
                    { new Guid("0f0e2fb7-aa7f-481a-93d7-47dbb90131f6"), new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), "Deluxe Veggie Pizza", 120.00m },
                    { new Guid("b44ed525-47d4-43db-a8f5-b63b69e4fe3e"), new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), "Green Wave Pizza", 150.00m },
                    { new Guid("17cfa138-d271-41da-a4f7-7f59c0c6f7f1"), new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), "Cheese Grill Sandwich", 70.00m },
                    { new Guid("03b3bc5c-2bbd-4b1f-a037-20122c458870"), new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), "Veg Pan Sandwich", 80.00m },
                    { new Guid("73cd3158-e6bb-4a87-b538-e5d0d618803a"), new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), "Coke", 20.00m },
                    { new Guid("63e72884-9b49-48c1-862b-e88da3778c36"), new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), "Maaza", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "FoodCategoryCustomization",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                values: new object[,]
                {
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("b57fb321-2a94-4348-854c-46c11e357687") },
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("b57fb321-2a94-4348-854c-46c11e357687") },
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a") },
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a") },
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2") },
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2") },
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("934892e8-e681-423e-aea4-5aceb08f1924") },
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa") }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomizationOption",
                columns: new[] { "Id", "FoodCustomizationId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("9343a562-4661-4c25-981d-a135290587dc"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"), "Barbeque", 10m },
                    { new Guid("e2cf48b0-029b-4749-a199-844a3fc71308"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"), "Southwest", 10m },
                    { new Guid("7724d404-74bc-4899-8252-852e8c71beb7"), new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"), "Cheddar", 10m },
                    { new Guid("733795d2-262e-4704-9812-1142ce97bf0b"), new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"), "Mozzarella", 10m },
                    { new Guid("59b32340-f361-42f8-9db7-d2ff5717f930"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"), "Honey Mustard", 10m },
                    { new Guid("6ff43eaf-0eb1-414e-9c50-827693f390f8"), new Guid("b57fb321-2a94-4348-854c-46c11e357687"), "Red Paprika", 20m },
                    { new Guid("5d71c087-480f-454f-8ada-35da547a9615"), new Guid("b57fb321-2a94-4348-854c-46c11e357687"), "Golden Corn", 20m },
                    { new Guid("263269ed-b5d7-4dc6-9e94-c880d872ec84"), new Guid("b57fb321-2a94-4348-854c-46c11e357687"), "Black Olive", 20m },
                    { new Guid("e7d47d1a-3258-4ed4-be76-9224bf8538ef"), new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"), "Oat", 10m },
                    { new Guid("1670990e-0b12-405d-aa10-9765dff0132e"), new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"), "Multi grain", 10m },
                    { new Guid("9a23f518-f226-4ca7-8fd6-268f9c3bf61e"), new Guid("934892e8-e681-423e-aea4-5aceb08f1924"), "Thin Crust", 50m },
                    { new Guid("901e02b5-49ab-4213-8395-d9a8907ca9f5"), new Guid("934892e8-e681-423e-aea4-5aceb08f1924"), "Fresh Pan", 50m },
                    { new Guid("bb040886-7243-446c-ad41-8affd6f06c3d"), new Guid("934892e8-e681-423e-aea4-5aceb08f1924"), "Hand Tossed", 50m },
                    { new Guid("d6f42205-9745-4189-98eb-a4381425bd23"), new Guid("b57fb321-2a94-4348-854c-46c11e357687"), "Panner", 20m }
                });

            migrationBuilder.InsertData(
                table: "RestaurantFoodCategoryMap",
                columns: new[] { "FoodCategoryId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82") },
                    { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d") },
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d") },
                    { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d") },
                    { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9") },
                    { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9") },
                    { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("03b3bc5c-2bbd-4b1f-a037-20122c458870"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0f0e2fb7-aa7f-481a-93d7-47dbb90131f6"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("17cfa138-d271-41da-a4f7-7f59c0c6f7f1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("4ceac9e8-b608-46c8-be4e-ca55498a713c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("63e72884-9b49-48c1-862b-e88da3778c36"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("73cd3158-e6bb-4a87-b538-e5d0d618803a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b44ed525-47d4-43db-a8f5-b63b69e4fe3e"));

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("934892e8-e681-423e-aea4-5aceb08f1924") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("b57fb321-2a94-4348-854c-46c11e357687") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("b57fb321-2a94-4348-854c-46c11e357687") });

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("1670990e-0b12-405d-aa10-9765dff0132e"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("263269ed-b5d7-4dc6-9e94-c880d872ec84"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("59b32340-f361-42f8-9db7-d2ff5717f930"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("5d71c087-480f-454f-8ada-35da547a9615"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("6ff43eaf-0eb1-414e-9c50-827693f390f8"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("733795d2-262e-4704-9812-1142ce97bf0b"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("7724d404-74bc-4899-8252-852e8c71beb7"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("901e02b5-49ab-4213-8395-d9a8907ca9f5"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("9343a562-4661-4c25-981d-a135290587dc"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("9a23f518-f226-4ca7-8fd6-268f9c3bf61e"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("bb040886-7243-446c-ad41-8affd6f06c3d"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("d6f42205-9745-4189-98eb-a4381425bd23"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("e2cf48b0-029b-4749-a199-844a3fc71308"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("e7d47d1a-3258-4ed4-be76-9224bf8538ef"));

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("5a7a32ad-b119-4117-a672-9b037f809438"), new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"), new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"), new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82") });

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("5a7a32ad-b119-4117-a672-9b037f809438"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("e7941eaa-d2c8-4983-86db-3f7c72dde5f3"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("f2fa1cf9-8b5e-4d2a-bfc9-504d521ad3c4"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("54e1b349-c90c-4a46-819b-735ada6e0faa"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("649bdc19-499b-4b6c-b29d-b8cc3e350ab2"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("7b679620-2a5e-49d2-bd0c-d45ab6e96f7a"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("934892e8-e681-423e-aea4-5aceb08f1924"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("b57fb321-2a94-4348-854c-46c11e357687"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("9ae787f1-920b-4a83-ba26-acd9613996e9"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("aff9cf54-b159-45b9-bc0f-5ea91901846d"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("c3669cb8-a4a3-4bd7-a2c2-698f1ae63a82"));

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), "Pizza" },
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), "Sandwiches" },
                    { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomization",
                columns: new[] { "Id", "CanSelectMultipleOptions", "Name" },
                values: new object[,]
                {
                    { new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"), false, "Pizza Base" },
                    { new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"), false, "Bread" },
                    { new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"), true, "Toppings" },
                    { new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"), true, "Cheese Options" },
                    { new Guid("29418ebf-edd5-47da-b716-c108b102a49e"), true, "Sauces" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e"), "McD" },
                    { new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8"), "Pizza Hut" },
                    { new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c"), "Sandwich Express" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "FoodCategoryId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("32181804-9ac7-4075-a94b-8682e689359b"), new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), "Farm House Pizza", 100.00m },
                    { new Guid("7d0ba04d-0372-4ecb-82e5-2c5f450a3514"), new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), "Deluxe Veggie Pizza", 120.00m },
                    { new Guid("41e46d0d-fc48-4cb0-a04a-b920ec274047"), new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), "Green Wave Pizza", 150.00m },
                    { new Guid("5f8342b0-7281-4e86-8a8a-f7825c97d992"), new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), "Cheese Grill Sandwich", 70.00m },
                    { new Guid("3c08fd06-f79e-4c5f-8a8f-8ef965388c43"), new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), "Veg Pan Sandwich", 80.00m },
                    { new Guid("c0629967-dd13-40cf-a1b6-5fd11d12441f"), new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), "Coke", 20.00m },
                    { new Guid("9a5cd69b-8052-4873-9e38-ef5c34f017af"), new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), "Maaza", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "FoodCategoryCustomization",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                values: new object[,]
                {
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f") },
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f") },
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e") },
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e") },
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b") },
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b") },
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e") },
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("ee47dd18-9327-417f-92a6-45f41003e89b") }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomizationOption",
                columns: new[] { "Id", "FoodCustomizationId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("5f62379f-9da1-43e3-b979-7dd0a6f60e42"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e"), "Barbeque", 10m },
                    { new Guid("65848a9d-b600-49b6-b39e-e93ea45219d7"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e"), "Southwest", 10m },
                    { new Guid("c9885167-2af3-4fb3-a33c-27ebf2f19797"), new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"), "Cheddar", 10m },
                    { new Guid("803bb2ff-b5aa-4926-9c78-04ca7969c879"), new Guid("fdd28c3f-1061-4dc6-afe3-1bdb7cf6055b"), "Mozzarella", 10m },
                    { new Guid("f4433799-dfab-42d5-b768-1f1a452497af"), new Guid("29418ebf-edd5-47da-b716-c108b102a49e"), "Honey Mustard", 10m },
                    { new Guid("63669850-7192-4a00-afbf-c224b552c6a2"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"), "Red Paprika", 20m },
                    { new Guid("ff66f592-ea64-4ebc-bbce-baac647d2de0"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"), "Golden Corn", 20m },
                    { new Guid("d83d8ca1-86cd-4a8e-bd97-b86a8cb8314f"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"), "Black Olive", 20m },
                    { new Guid("327ae44a-805e-4b7a-a722-1281cc05ac93"), new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"), "Oat", 10m },
                    { new Guid("b8ef553c-940a-4912-a1a5-73a2e52cb6dc"), new Guid("ee47dd18-9327-417f-92a6-45f41003e89b"), "Multi grain", 10m },
                    { new Guid("25f521a6-446b-4568-b8d6-1648ba7efd14"), new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"), "Thin Crust", 50m },
                    { new Guid("d9781947-135a-482a-8575-892002a05482"), new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"), "Fresh Pan", 50m },
                    { new Guid("941876df-dbb2-4883-8a90-394f395e6734"), new Guid("156bc9fc-de6b-4cae-a8f7-918a42f9527e"), "Hand Tossed", 50m },
                    { new Guid("4ce749b4-6007-4eee-b9aa-8d84bb6f51fb"), new Guid("6305c02c-8df8-47c6-9989-68c54ce76d2f"), "Panner", 20m }
                });

            migrationBuilder.InsertData(
                table: "RestaurantFoodCategoryMap",
                columns: new[] { "FoodCategoryId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c") },
                    { new Guid("2cfa74c4-c3b1-437e-b2f7-31094928fb1d"), new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e") },
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e") },
                    { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), new Guid("26223d08-0fe8-4141-8a99-6b4c83e00e5e") },
                    { new Guid("54bf98d5-1268-44e6-8d5b-5b9f3c276521"), new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8") },
                    { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), new Guid("fce79290-83d9-46ff-a7af-9c2b5649f3f8") },
                    { new Guid("c75af3a4-9a68-411e-8057-44ce20ef2777"), new Guid("26177e06-2c3a-4c47-a896-c29fb9e9cd8c") }
                });
        }
    }
}
