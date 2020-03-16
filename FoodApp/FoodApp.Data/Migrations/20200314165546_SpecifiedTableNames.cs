using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodApp.Data.Migrations
{
    public partial class SpecifiedTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryCustomizationMap_FoodCategory_FoodCategoryId",
                table: "FoodCategoryCustomizationMap");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryCustomizationMap_FoodCustomization_FoodCustomizationId",
                table: "FoodCategoryCustomizationMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodCategoryCustomizationMap",
                table: "FoodCategoryCustomizationMap");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("084e4591-c780-441e-9c8e-4dc9d29607d2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("20e82ea5-ed2a-4694-9ecc-1d9b8a56bec9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("2461a153-60c5-4099-9d17-93631f60c492"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("2ee15831-c9ca-4a92-a4e3-f767746d0f2e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("9f5b5155-62d8-46af-b13a-03521b7c1426"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c56fcc27-5964-4ff8-8e1e-4a9b7af1639b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e4682fe3-3b42-4a45-ab5a-b045601c48f8"));

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("9201bebb-4d6c-4687-91a4-7852c3eccde8") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("b31238f0-cb90-4685-b557-63b753e626fc") });

            migrationBuilder.DeleteData(
                table: "FoodCategoryCustomizationMap",
                keyColumns: new[] { "FoodCategoryId", "FoodCustomizationId" },
                keyValues: new object[] { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("cdb33d31-410d-400d-80d3-5b5a36552087") });

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("11d19067-02b5-4048-934d-8b12003c699b"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("19162233-6bcc-4ed1-bf67-c686971d97c4"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("32d77afd-524e-43b0-ae32-f32da9ba2bd8"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("3a3a44f0-2933-43d5-a315-24559a5164e0"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("4eceef39-4a83-4020-bb29-ad780ef84fa4"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("5398b950-ec7a-41d8-ab5e-4a3b47e8221f"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("70c18ed3-fd4e-41b0-86a4-9f9e68fcd2fb"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("73698dd9-64f6-4217-abb4-f9ccbb3a6bfc"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("87d5d2b5-ad73-4de6-9b69-717b5d07b9f5"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("b33079a6-a194-430a-bdb1-d481ec9415e7"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("b984a618-766b-4c1c-a610-5e149e3cfc6a"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("be156703-655e-4ef3-a37d-25b52435fc55"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("e38bfc14-7c57-44b9-80ee-4d15ce6a4cf3"));

            migrationBuilder.DeleteData(
                table: "FoodCustomizationOption",
                keyColumn: "Id",
                keyValue: new Guid("e83bf8ce-12a1-46d4-bb57-f1fa0acb28d9"));

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("ad614b15-fa07-423b-9d6e-44311ba4f53c") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"), new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("f03ff63b-d988-4978-bde8-868006cf7f72") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("853df491-1f78-4e52-8481-169be59fd295"), new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), new Guid("ad614b15-fa07-423b-9d6e-44311ba4f53c") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), new Guid("f03ff63b-d988-4978-bde8-868006cf7f72") });

            migrationBuilder.DeleteData(
                table: "RestaurantFoodCategoryMap",
                keyColumns: new[] { "FoodCategoryId", "RestaurantId" },
                keyValues: new object[] { new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"), new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb") });

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("46a29b5e-d39e-4c2a-a581-f22ee29c1c71"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("853df491-1f78-4e52-8481-169be59fd295"));

            migrationBuilder.DeleteData(
                table: "FoodCategory",
                keyColumn: "Id",
                keyValue: new Guid("9780fbe4-a8ea-481e-a5d6-bbd630461a89"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("9086ece6-b731-4ed1-aa4a-8c108026f7fd"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("9201bebb-4d6c-4687-91a4-7852c3eccde8"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("b31238f0-cb90-4685-b557-63b753e626fc"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("cdb33d31-410d-400d-80d3-5b5a36552087"));

            migrationBuilder.DeleteData(
                table: "FoodCustomization",
                keyColumn: "Id",
                keyValue: new Guid("f27ba1e8-100b-48b2-a8af-143e137de19c"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("ad614b15-fa07-423b-9d6e-44311ba4f53c"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("f03ff63b-d988-4978-bde8-868006cf7f72"));

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("ff77b5c9-bfdd-4493-981e-b5a919d431fb"));

            migrationBuilder.RenameTable(
                name: "FoodCategoryCustomizationMap",
                newName: "FoodCategoryCustomization");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategoryCustomizationMap_FoodCustomizationId",
                table: "FoodCategoryCustomization",
                newName: "IX_FoodCategoryCustomization_FoodCustomizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodCategoryCustomization",
                table: "FoodCategoryCustomization",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryCustomization_FoodCategory_FoodCategoryId",
                table: "FoodCategoryCustomization",
                column: "FoodCategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryCustomization_FoodCustomization_FoodCustomizationId",
                table: "FoodCategoryCustomization",
                column: "FoodCustomizationId",
                principalTable: "FoodCustomization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryCustomization_FoodCategory_FoodCategoryId",
                table: "FoodCategoryCustomization");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryCustomization_FoodCustomization_FoodCustomizationId",
                table: "FoodCategoryCustomization");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodCategoryCustomization",
                table: "FoodCategoryCustomization");

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

            migrationBuilder.RenameTable(
                name: "FoodCategoryCustomization",
                newName: "FoodCategoryCustomizationMap");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategoryCustomization_FoodCustomizationId",
                table: "FoodCategoryCustomizationMap",
                newName: "IX_FoodCategoryCustomizationMap_FoodCustomizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodCategoryCustomizationMap",
                table: "FoodCategoryCustomizationMap",
                columns: new[] { "FoodCategoryId", "FoodCustomizationId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryCustomizationMap_FoodCategory_FoodCategoryId",
                table: "FoodCategoryCustomizationMap",
                column: "FoodCategoryId",
                principalTable: "FoodCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryCustomizationMap_FoodCustomization_FoodCustomizationId",
                table: "FoodCategoryCustomizationMap",
                column: "FoodCustomizationId",
                principalTable: "FoodCustomization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
