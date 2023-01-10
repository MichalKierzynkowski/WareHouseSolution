using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Changenameofthemargin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSale_Sale_SalesId",
                table: "ReturnSale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleWareHouse_Sale_SalesId",
                table: "SaleWareHouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameColumn(
                name: "Dreams",
                table: "Sales",
                newName: "Margin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSale_Sales_SalesId",
                table: "ReturnSale",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleWareHouse_Sales_SalesId",
                table: "SaleWareHouse",
                column: "SalesId",
                principalTable: "Sales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSale_Sales_SalesId",
                table: "ReturnSale");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleWareHouse_Sales_SalesId",
                table: "SaleWareHouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameColumn(
                name: "Margin",
                table: "Sale",
                newName: "Dreams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSale_Sale_SalesId",
                table: "ReturnSale",
                column: "SalesId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleWareHouse_Sale_SalesId",
                table: "SaleWareHouse",
                column: "SalesId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
