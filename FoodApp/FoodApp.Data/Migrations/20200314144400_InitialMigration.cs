using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodApp.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCustomization",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    CanSelectMultipleOptions = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCustomization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FoodCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_FoodCategory_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategoryCustomizationMap",
                columns: table => new
                {
                    FoodCategoryId = table.Column<Guid>(nullable: false),
                    FoodCustomizationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategoryCustomizationMap", x => new { x.FoodCategoryId, x.FoodCustomizationId });
                    table.ForeignKey(
                        name: "FK_FoodCategoryCustomizationMap_FoodCategory_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategoryCustomizationMap_FoodCustomization_FoodCustomizationId",
                        column: x => x.FoodCustomizationId,
                        principalTable: "FoodCustomization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCustomizationOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FoodCustomizationId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(5, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCustomizationOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodCustomizationOption_FoodCustomization_FoodCustomizationId",
                        column: x => x.FoodCustomizationId,
                        principalTable: "FoodCustomization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantFoodCategoryMap",
                columns: table => new
                {
                    RestaurantId = table.Column<Guid>(nullable: false),
                    FoodCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantFoodCategoryMap", x => new { x.FoodCategoryId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantFoodCategoryMap_FoodCategory_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantFoodCategoryMap_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), "Pizza" },
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), "Sandwiches" },
                    { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), "Drinks" }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomization",
                columns: new[] { "Id", "CanSelectMultipleOptions", "Name" },
                values: new object[,]
                {
                    { new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c"), false, "Pizza Base" },
                    { new Guid("9201bebb-4d6c-4687-91a4-7852c3eccde8"), false, "Bread" },
                    { new Guid("cdb33d31-410d-400d-80d3-5b5a36552087"), true, "Toppings" },
                    { new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd"), true, "Cheese Options" },
                    { new Guid("b31238f0-cb90-4685-b557-63b753e626fc"), true, "Sauces" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb"), "McD" },
                    { new Guid("ad614b15-fa07-423b-9d6e-44311ba4f53c"), "Pizza Hut" },
                    { new Guid("f03ff63b-d988-4978-bde8-868006cf7f72"), "Sandwich Express" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "FoodCategoryId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("2461a153-60c5-4099-9d17-93631f60c492"), new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), "Farm House Pizza", 100.00m },
                    { new Guid("9f5b5155-62d8-46af-b13a-03521b7c1426"), new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), "Deluxe Veggie Pizza", 120.00m },
                    { new Guid("20e82ea5-ed2a-4694-9ecc-1d9b8a56bec9"), new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), "Green Wave Pizza", 150.00m },
                    { new Guid("2ee15831-c9ca-4a92-a4e3-f767746d0f2e"), new Guid("853df491-1f78-4e52-8481-169be59fd295"), "Cheese Grill Sandwich", 70.00m },
                    { new Guid("e4682fe3-3b42-4a45-ab5a-b045601c48f8"), new Guid("853df491-1f78-4e52-8481-169be59fd295"), "Veg Pan Sandwich", 80.00m },
                    { new Guid("084e4591-c780-441e-9c8e-4dc9d29607d2"), new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), "Coke", 20.00m },
                    { new Guid("c56fcc27-5964-4ff8-8e1e-4a9b7af1639b"), new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), "Maaza", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "FoodCategoryCustomizationMap",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                values: new object[,]
                {
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087") },
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087") },
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc") },
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc") },
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd") },
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd") },
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c") },
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("9201bebb-4d6c-4687-91a4-7852c3eccde8") }
                });

            migrationBuilder.InsertData(
                table: "FoodCustomizationOption",
                columns: new[] { "Id", "FoodCustomizationId", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("e83bf8ce-12a1-46d4-bb57-f1fa0acb28d9"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc"), "Barbeque", 10m },
                    { new Guid("32d77afd-524e-43b0-ae32-f32da9ba2bd8"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc"), "Southwest", 10m },
                    { new Guid("73698dd9-64f6-4217-abb4-f9ccbb3a6bfc"), new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd"), "Cheddar", 10m },
                    { new Guid("3a3a44f0-2933-43d5-a315-24559a5164e0"), new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd"), "Mozzarella", 10m },
                    { new Guid("b984a618-766b-4c1c-a610-5e149e3cfc6a"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc"), "Honey Mustard", 10m },
                    { new Guid("11d19067-02b5-4048-934d-8b12003c699b"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087"), "Red Paprika", 20m },
                    { new Guid("e38bfc14-7c57-44b9-80ee-4d15ce6a4cf3"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087"), "Golden Corn", 20m },
                    { new Guid("5398b950-ec7a-41d8-ab5e-4a3b47e8221f"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087"), "Black Olive", 20m },
                    { new Guid("be156703-655e-4ef3-a37d-25b52435fc55"), new Guid("9201bebb-4d6c-4687-91a4-7852c3eccde8"), "Oat", 10m },
                    { new Guid("4eceef39-4a83-4020-bb29-ad780ef84fa4"), new Guid("9201bebb-4d6c-4687-91a4-7852c3eccde8"), "Multi grain", 10m },
                    { new Guid("19162233-6bcc-4ed1-bf67-c686971d97c4"), new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c"), "Thin Crust", 50m },
                    { new Guid("b33079a6-a194-430a-bdb1-d481ec9415e7"), new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c"), "Fresh Pan", 50m },
                    { new Guid("70c18ed3-fd4e-41b0-86a4-9f9e68fcd2fb"), new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c"), "Hand Tossed", 50m },
                    { new Guid("87d5d2b5-ad73-4de6-9b69-717b5d07b9f5"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087"), "Panner", 20m }
                });

            migrationBuilder.InsertData(
                table: "RestaurantFoodCategoryMap",
                columns: new[] { "FoodCategoryId", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("f03ff63b-d988-4978-bde8-868006cf7f72") },
                    { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb") },
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb") },
                    { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb") },
                    { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("ad614b15-fa07-423b-9d6e-44311ba4f53c") },
                    { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), new Guid("ad614b15-fa07-423b-9d6e-44311ba4f53c") },
                    { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), new Guid("f03ff63b-d988-4978-bde8-868006cf7f72") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodCategoryId",
                table: "Food",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategoryCustomizationMap_FoodCustomizationId",
                table: "FoodCategoryCustomizationMap",
                column: "FoodCustomizationId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCustomizationOption_FoodCustomizationId",
                table: "FoodCustomizationOption",
                column: "FoodCustomizationId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantFoodCategoryMap_RestaurantId",
                table: "RestaurantFoodCategoryMap",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "FoodCategoryCustomizationMap");

            migrationBuilder.DropTable(
                name: "FoodCustomizationOption");

            migrationBuilder.DropTable(
                name: "RestaurantFoodCategoryMap");

            migrationBuilder.DropTable(
                name: "FoodCustomization");

            migrationBuilder.DropTable(
                name: "FoodCategory");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
