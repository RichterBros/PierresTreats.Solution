using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class modelsChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Treats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Flavors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Flavors");
        }
    }
}
