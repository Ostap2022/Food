using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flint.Migrations
{
    public partial class newmigration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Purchases",
                newName: "CustomerId");

            migrationBuilder.AddColumn<Guid>(
                name: "ChipsId",
                table: "Purchases",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChipsId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Purchases",
                newName: "ProductId");
        }
    }
}
