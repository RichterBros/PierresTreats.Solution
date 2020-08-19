using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Flavors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Treats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Flavors",
                nullable: true);
        }
    }
}
