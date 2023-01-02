using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddReturnsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReturnId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Returns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    SellPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returns", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ReturnId",
                table: "Products",
                column: "ReturnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Returns_ReturnId",
                table: "Products",
                column: "ReturnId",
                principalTable: "Returns",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Returns_ReturnId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Returns");

            migrationBuilder.DropIndex(
                name: "IX_Products_ReturnId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ReturnId",
                table: "Products");
        }
    }
}
