using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodApp.Data.Migrations
{
    public partial class UserDataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), "Pizza" },
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), "Sandwiches" },
                    { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomization",
                columns: new[] { "Id", "CanSelectMultipleOptions", "Name" },
                values: new object[,]
                {
                    { new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"), false, "Pizza Base" },
                    { new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"), false, "Bread" },
                    { new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"), true, "Toppings" },
                    { new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"), true, "Cheese Options" },
                    { new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"), true, "Sauces" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e416791b-0a71-42da-8e59-e8b16763ce16"), "McD" },
                    { new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051"), "Pizza Hut" },
                    { new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd"), "Sandwich Express" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "UserType" },
                values: new object[] { new Guid("7239b67e-35e1-49a2-be04-08accc493a4f"), "admin@foodapp.com", "Admin", "Admin", "$2a$11$cJh8vjqPHj/xnIlHHRSUJuPDRlKJhtUokO9qQn8w/u8AgHNKTKdSS", 1 });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "FoodCategoryId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("604ed849-01d3-480d-920c-1135dc3e4ed3"), new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), "Farm House Pizza", 100.00m },
                    { new Guid("b8cb83b1-746d-4815-9090-0258b2b3b777"), new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), "Deluxe Veggie Pizza", 120.00m },
                    { new Guid("d71be51e-dba1-43a8-b0de-7ea8b7a119f3"), new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), "Green Wave Pizza", 150.00m },
                    { new Guid("8fd6797f-a0c4-44d9-83c4-8fb852711650"), new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), "Cheese Grill Sandwich", 70.00m },
                    { new Guid("227a1100-dc39-4177-a4af-d3cce82debac"), new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), "Veg Pan Sandwich", 80.00m },
                    { new Guid("fdb77ed9-3e0c-484b-a65d-1e286d64937b"), new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), "Coke", 20.00m },
                    { new Guid("ec86a43d-1d51-451a-9882-5bf050e0248c"), new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), "Maaza", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "FoodCategoryCustomization",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                values: new object[,]
                {
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f") },
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f") },
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4") },
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4") },
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b") },
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b") },
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a") },
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263") }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomizationOption",
                columns: new[] { "Id", "FoodCustomizationId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("db7cee3d-e034-4cff-b6f7-ecc7011fbf73"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"), "Barbeque", 10m },
                    { new Guid("298c9a95-7fd6-45d8-9ad3-60ff92a98223"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"), "Southwest", 10m },
                    { new Guid("78ee0259-5585-4284-814d-c036f7c694c7"), new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"), "Cheddar", 10m },
                    { new Guid("d0b51320-e31b-478b-9461-7dc17862ed12"), new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"), "Mozzarella", 10m },
                    { new Guid("483271ed-ed31-46a6-9cf2-7f47dd5ca9dd"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"), "Honey Mustard", 10m },
                    { new Guid("70d9ad31-a8af-4976-b055-5cf2fcdacd14"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"), "Red Paprika", 20m },
                    { new Guid("108ee6a9-60b8-454e-8b88-b5728f3290cc"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"), "Golden Corn", 20m },
                    { new Guid("0eeaba91-286b-4082-a7a4-162bb4bab564"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"), "Black Olive", 20m },
                    { new Guid("bb5d3c34-28d4-4bed-8930-05bb48d60bc4"), new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"), "Oat", 10m },
                    { new Guid("eba6ff86-02d2-4356-9901-fc583e52b074"), new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"), "Multi grain", 10m },
                    { new Guid("446eb183-db6d-4ac6-a77a-e40b70c0e774"), new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"), "Thin Crust", 50m },
                    { new Guid("81c1439f-4862-4aba-a1ef-c7fdf5eda2e0"), new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"), "Fresh Pan", 50m },
                    { new Guid("5ba0f5eb-646b-4af0-96c7-e914eb83dd3c"), new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"), "Hand Tossed", 50m },
                    { new Guid("87cce679-0a3c-4efe-94f5-d4f94e1fb6f9"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"), "Panner", 20m }
                });

            migrationBuilder.InsertData(
                table: "RestaurantFoodCategoryMap",
                columns: new[] { "FoodCategoryId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd") },
                    { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("e416791b-0a71-42da-8e59-e8b16763ce16") },
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("e416791b-0a71-42da-8e59-e8b16763ce16") },
                    { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), new Guid("e416791b-0a71-42da-8e59-e8b16763ce16") },
                    { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051") },
                    { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051") },
                    { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("227a1100-dc39-4177-a4af-d3cce82debac"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("604ed849-01d3-480d-920c-1135dc3e4ed3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8fd6797f-a0c4-44d9-83c4-8fb852711650"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b8cb83b1-746d-4815-9090-0258b2b3b777"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d71be51e-dba1-43a8-b0de-7ea8b7a119f3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ec86a43d-1d51-451a-9882-5bf050e0248c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("fdb77ed9-3e0c-484b-a65d-1e286d64937b"));

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b") });

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("0eeaba91-286b-4082-a7a4-162bb4bab564"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("108ee6a9-60b8-454e-8b88-b5728f3290cc"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("298c9a95-7fd6-45d8-9ad3-60ff92a98223"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("446eb183-db6d-4ac6-a77a-e40b70c0e774"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("483271ed-ed31-46a6-9cf2-7f47dd5ca9dd"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("5ba0f5eb-646b-4af0-96c7-e914eb83dd3c"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("70d9ad31-a8af-4976-b055-5cf2fcdacd14"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("78ee0259-5585-4284-814d-c036f7c694c7"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("81c1439f-4862-4aba-a1ef-c7fdf5eda2e0"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("87cce679-0a3c-4efe-94f5-d4f94e1fb6f9"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("bb5d3c34-28d4-4bed-8930-05bb48d60bc4"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("d0b51320-e31b-478b-9461-7dc17862ed12"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("db7cee3d-e034-4cff-b6f7-ecc7011fbf73"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("eba6ff86-02d2-4356-9901-fc583e52b074"));

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("17520549-f179-48e7-8a08-34c86e2571f8"), new Guid("e416791b-0a71-42da-8e59-e8b16763ce16") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"), new Guid("e416791b-0a71-42da-8e59-e8b16763ce16") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"), new Guid("e416791b-0a71-42da-8e59-e8b16763ce16") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7239b67e-35e1-49a2-be04-08accc493a4f"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("17520549-f179-48e7-8a08-34c86e2571f8"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("bcb6faf7-4ab2-4426-97e3-97bc3eaae542"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("cda0af47-b6cf-4486-b117-376c7c0751ef"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("0f7ef7af-6fb3-4ec7-b1f7-58c659e0d263"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("4b0d16d4-2648-418c-8306-1f3f403f0d0f"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("64d3b704-7d64-4b46-a884-e60a8895f2c4"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("8a61700d-db36-4f22-8dca-c23221ab9e5a"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("f1b5eb7b-bcc1-45d8-a586-d0d4abd8316b"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("87f50f73-a0c7-40d2-afef-ba58e582d4bd"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("dd0a334d-f680-40ac-8ae0-9e2115681051"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("e416791b-0a71-42da-8e59-e8b16763ce16"));

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
    }
}
