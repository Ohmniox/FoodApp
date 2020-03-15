using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodApp.Data.Migrations
{
    public partial class AddedOrderEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    RestaurantId = table.Column<Guid>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(7, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderLine",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    FoodId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLine_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLineOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderLineId = table.Column<Guid>(nullable: false),
                    FoodCustomizationOptionId = table.Column<Guid>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLineOption_OrderLine_OrderLineId",
                        column: x => x.OrderLineId,
                        principalTable: "OrderLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), "Pizza" },
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), "Sandwiches" },
                    { new Guid("37706f0a-5309-4820-8529-33e98590f532"), "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomization",
                columns: new[] { "Id", "CanSelectMultipleOptions", "Name" },
                values: new object[,]
                {
                    { new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"), false, "Pizza Base" },
                    { new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"), false, "Bread" },
                    { new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"), true, "Toppings" },
                    { new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"), true, "Cheese Options" },
                    { new Guid("515da683-6caf-473f-9f17-17aa50021d82"), true, "Sauces" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e"), "McD" },
                    { new Guid("b94f227b-1865-4850-8556-876a03bb6a92"), "Pizza Hut" },
                    { new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7"), "Sandwich Express" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "UserType" },
                values: new object[] { new Guid("6cbca69d-e9a1-4896-a1b3-35205f86a3b0"), "admin@foodapp.com", "Admin", "Admin", "$2a$11$gkBFRKDn7v8xUicttBIfkOZ/NinK7NdB9Zl.Xd0bfh9laaXO4bhP6", 1 });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "FoodCategoryId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("6812e44b-136e-4c90-8c8f-19a8755227b9"), new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), "Farm House Pizza", 100.00m },
                    { new Guid("95bb4d6c-6642-4874-a4fb-9c89c0fad96f"), new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), "Deluxe Veggie Pizza", 120.00m },
                    { new Guid("3479ce8f-ad14-43f1-89e2-305e0ec9d7d1"), new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), "Green Wave Pizza", 150.00m },
                    { new Guid("ae2adadb-c7c9-431b-bebe-0fb5696aec5c"), new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), "Cheese Grill Sandwich", 70.00m },
                    { new Guid("01de8efa-b104-4f4c-a06e-1aeac87a058d"), new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), "Veg Pan Sandwich", 80.00m },
                    { new Guid("f8b743b5-4ac4-4fd9-8d61-9d3f230752bb"), new Guid("37706f0a-5309-4820-8529-33e98590f532"), "Coke", 20.00m },
                    { new Guid("13ad8c09-3a52-439b-b5cf-7e45cb73a93d"), new Guid("37706f0a-5309-4820-8529-33e98590f532"), "Maaza", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "FoodCategoryCustomization",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                values: new object[,]
                {
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983") },
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983") },
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("515da683-6caf-473f-9f17-17aa50021d82") },
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("515da683-6caf-473f-9f17-17aa50021d82") },
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0") },
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0") },
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0") },
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a") }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomizationOption",
                columns: new[] { "Id", "FoodCustomizationId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("7c202c73-cdf7-4c96-88ed-03f7a66de8f3"), new Guid("515da683-6caf-473f-9f17-17aa50021d82"), "Barbeque", 10m },
                    { new Guid("391f0017-9c03-4a04-9640-d2adcc485995"), new Guid("515da683-6caf-473f-9f17-17aa50021d82"), "Southwest", 10m },
                    { new Guid("e743e020-9b3c-4e3b-961e-c99ede8967fb"), new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"), "Cheddar", 10m },
                    { new Guid("d92b9add-a74b-4959-8acd-3833863838ec"), new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"), "Mozzarella", 10m },
                    { new Guid("407d019d-2b50-4d3d-aff2-37d19d5c13f3"), new Guid("515da683-6caf-473f-9f17-17aa50021d82"), "Honey Mustard", 10m },
                    { new Guid("c3a0fadd-3a2d-4244-8bc9-166f837bc943"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"), "Red Paprika", 20m },
                    { new Guid("eff92807-35c0-4d4e-a677-b11bae3acb38"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"), "Golden Corn", 20m },
                    { new Guid("590c3ece-daa1-406a-a324-b2571d47edfa"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"), "Black Olive", 20m },
                    { new Guid("763d6ae6-6bb6-43fb-b7ef-a16b3ba6bf29"), new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"), "Oat", 10m },
                    { new Guid("65754491-842f-4116-9461-5b945a07ac5c"), new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"), "Multi grain", 10m },
                    { new Guid("e81fdd73-78e8-4836-8030-6b57b440360a"), new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"), "Thin Crust", 50m },
                    { new Guid("254e6270-854c-4976-8f3e-f91efc35189d"), new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"), "Fresh Pan", 50m },
                    { new Guid("ced57abc-d59a-4a55-9395-213ac61acf49"), new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"), "Hand Tossed", 50m },
                    { new Guid("b090ee10-6214-46fb-b6b4-ae0425200af5"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"), "Panner", 20m }
                });

            migrationBuilder.InsertData(
                table: "RestaurantFoodCategoryMap",
                columns: new[] { "FoodCategoryId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7") },
                    { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e") },
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e") },
                    { new Guid("37706f0a-5309-4820-8529-33e98590f532"), new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e") },
                    { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("b94f227b-1865-4850-8556-876a03bb6a92") },
                    { new Guid("37706f0a-5309-4820-8529-33e98590f532"), new Guid("b94f227b-1865-4850-8556-876a03bb6a92") },
                    { new Guid("37706f0a-5309-4820-8529-33e98590f532"), new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderLine_OrderId",
                table: "OrderLine",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineOption_OrderLineId",
                table: "OrderLineOption",
                column: "OrderLineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderLineOption");

            migrationBuilder.DropTable(
                name: "OrderLine");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("01de8efa-b104-4f4c-a06e-1aeac87a058d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("13ad8c09-3a52-439b-b5cf-7e45cb73a93d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3479ce8f-ad14-43f1-89e2-305e0ec9d7d1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("6812e44b-136e-4c90-8c8f-19a8755227b9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("95bb4d6c-6642-4874-a4fb-9c89c0fad96f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ae2adadb-c7c9-431b-bebe-0fb5696aec5c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f8b743b5-4ac4-4fd9-8d61-9d3f230752bb"));

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("515da683-6caf-473f-9f17-17aa50021d82") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("515da683-6caf-473f-9f17-17aa50021d82") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomization",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983") });

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("254e6270-854c-4976-8f3e-f91efc35189d"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("391f0017-9c03-4a04-9640-d2adcc485995"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("407d019d-2b50-4d3d-aff2-37d19d5c13f3"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("590c3ece-daa1-406a-a324-b2571d47edfa"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("65754491-842f-4116-9461-5b945a07ac5c"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("763d6ae6-6bb6-43fb-b7ef-a16b3ba6bf29"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("7c202c73-cdf7-4c96-88ed-03f7a66de8f3"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("b090ee10-6214-46fb-b6b4-ae0425200af5"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("c3a0fadd-3a2d-4244-8bc9-166f837bc943"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("ced57abc-d59a-4a55-9395-213ac61acf49"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("d92b9add-a74b-4959-8acd-3833863838ec"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("e743e020-9b3c-4e3b-961e-c99ede8967fb"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("e81fdd73-78e8-4836-8030-6b57b440360a"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("eff92807-35c0-4d4e-a677-b11bae3acb38"));

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"), new Guid("b94f227b-1865-4850-8556-876a03bb6a92") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("37706f0a-5309-4820-8529-33e98590f532"), new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("37706f0a-5309-4820-8529-33e98590f532"), new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("37706f0a-5309-4820-8529-33e98590f532"), new Guid("b94f227b-1865-4850-8556-876a03bb6a92") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"), new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6cbca69d-e9a1-4896-a1b3-35205f86a3b0"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("24605dbf-fda0-4001-9cd9-ed29f24b4f3a"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("37706f0a-5309-4820-8529-33e98590f532"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("8fbe84f8-f746-45e9-b679-75f8d7971d6f"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("2d6d5a19-cb3d-4b7a-a8cb-9a51b85db94a"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("515da683-6caf-473f-9f17-17aa50021d82"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("6752518f-a587-4efd-9956-c2dc0a3341d0"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("8069e3c0-0642-4633-bc15-6928e54b16b0"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("9917ec41-5ade-4a64-af24-ad034cc4f983"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("19298ebd-7ab5-4010-9ef3-fba93a575fb7"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("3fe35dd2-beb3-4e5d-94de-2252c1ffcb9e"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("b94f227b-1865-4850-8556-876a03bb6a92"));

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
    }
}
