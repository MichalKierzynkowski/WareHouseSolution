using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddSaleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentMethod = table.Column<string>(type: "TEXT", nullable: false),
                    EndPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Discount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Dreams = table.Column<double>(type: "REAL", nullable: false),
                    Profit = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnSale",
                columns: table => new
                {
                    ReturnsId = table.Column<int>(type: "INTEGER", nullable: false),
                    SalesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnSale", x => new { x.ReturnsId, x.SalesId });
                    table.ForeignKey(
                        name: "FK_ReturnSale_Returns_ReturnsId",
                        column: x => x.ReturnsId,
                        principalTable: "Returns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnSale_Sale_SalesId",
                        column: x => x.SalesId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleWareHouse",
                columns: table => new
                {
                    SalesId = table.Column<int>(type: "INTEGER", nullable: false),
                    WareHousesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleWareHouse", x => new { x.SalesId, x.WareHousesId });
                    table.ForeignKey(
                        name: "FK_SaleWareHouse_Sale_SalesId",
                        column: x => x.SalesId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleWareHouse_WareHouse_WareHousesId",
                        column: x => x.WareHousesId,
                        principalTable: "WareHouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSale_SalesId",
                table: "ReturnSale",
                column: "SalesId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleWareHouse_WareHousesId",
                table: "SaleWareHouse",
                column: "WareHousesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnSale");

            migrationBuilder.DropTable(
                name: "SaleWareHouse");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
