using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class updateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1,
                column: "Type",
                value: "British Shorthair");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2,
                column: "Type",
                value: "Bengal Cat");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3,
                column: "Type",
                value: "Siamese");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4,
                column: "Type",
                value: "Turkish Angora");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5,
                column: "Type",
                value: "Birman");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1,
                column: "Type",
                value: "Shiba Inu");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2,
                column: "Type",
                value: "Shiba Inu");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3,
                column: "Type",
                value: "Shiba Inu");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4,
                column: "Type",
                value: "Shiba Inu");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5,
                column: "Type",
                value: "Shiba Inu");
        }
    }
}
