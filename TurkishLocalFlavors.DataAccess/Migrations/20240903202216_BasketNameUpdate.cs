using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurkishLocalFlavors.DataAccess.Migrations
{
    public partial class BasketNameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotoalPrice",
                table: "Baskets",
                newName: "TotalPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Baskets",
                newName: "TotoalPrice");
        }
    }
}
