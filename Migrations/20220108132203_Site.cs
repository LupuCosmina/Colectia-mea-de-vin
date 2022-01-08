using Microsoft.EntityFrameworkCore.Migrations;

namespace Colectia_mea_de_vin.Migrations
{
    public partial class Site : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                table: "Vin",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vin_SiteID",
                table: "Vin",
                column: "SiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vin_Site_SiteID",
                table: "Vin",
                column: "SiteID",
                principalTable: "Site",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vin_Site_SiteID",
                table: "Vin");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropIndex(
                name: "IX_Vin_SiteID",
                table: "Vin");

            migrationBuilder.DropColumn(
                name: "SiteID",
                table: "Vin");
        }
    }
}
