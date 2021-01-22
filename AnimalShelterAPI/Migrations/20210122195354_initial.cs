using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, "Delirium", "Shiba Inu" },
                    { 2, 3, "Sprite", "Shiba Inu" },
                    { 3, 7, "Castle", "Shiba Inu" },
                    { 4, 5, "Cleo", "Shiba Inu" },
                    { 5, 4, "Frank", "Shiba Inu" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Shiba Inu", "Ragnar" },
                    { 2, 2, "Miniature Pincher", "Gauge" },
                    { 3, 1, "Doberman", "Ren" },
                    { 4, 10, "Pit Bull", "Kratos" },
                    { 5, 6, "Husky", "Odin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
