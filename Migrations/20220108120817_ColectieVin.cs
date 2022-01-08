using Microsoft.EntityFrameworkCore.Migrations;

namespace Colectia_mea_de_vin.Migrations
{
    public partial class ColectieVin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeCategorie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieVin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VinID = table.Column<int>(nullable: false),
                    CategorieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieVin", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategorieVin_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieVin_Vin_VinID",
                        column: x => x.VinID,
                        principalTable: "Vin",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorieVin_CategorieID",
                table: "CategorieVin",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieVin_VinID",
                table: "CategorieVin",
                column: "VinID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorieVin");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
