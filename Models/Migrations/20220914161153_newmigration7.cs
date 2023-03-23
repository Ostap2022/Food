using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flint.Migrations
{
    public partial class newmigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PurchaseId",
                table: "Purchases",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Purchases",
                newName: "PurchaseId");
        }
    }
}
