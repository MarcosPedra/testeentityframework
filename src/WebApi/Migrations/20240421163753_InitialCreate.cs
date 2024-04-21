using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "varchar(30)", nullable: false),
                    Model = table.Column<string>(type: "varchar(30)", nullable: false),
                    Color = table.Column<string>(type: "varchar(60)", nullable: false),
                    YearManufacture = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Brand", "Color", "Model", "YearManufacture" },
                values: new object[,]
                {
                    { new Guid("5509ba04-6128-41b2-bc50-1ce7b6577e68"), "Ford", "Cinza", "F600", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78665b5b-e8ba-4528-82c9-446e7dafa2d3"), "Chevrolet", "Preto", "Onix", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aaabbdb8-63fc-4009-94dd-625f31815381"), "Fiat", "Prata", "Siena", new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c927299c-01a0-4316-8531-0944c727960f"), "Fiat", "Branco", "Uno", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da808ea4-8cb0-4be7-852d-3211a1c1b2bc"), "Ford", "Chumbo", "F1000", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
