using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.Data.Migrations
{
    public partial class AddBasePriceToSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_Type",
                columns: table => new
                {
                    Type_Product = table.Column<int>(type: "int", nullable: false),
                    Product_Type_Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product___0AE0A2F9B8A41457", x => x.Type_Product);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Methods",
                columns: table => new
                {
                    Purchase_Method = table.Column<int>(type: "int", nullable: false),
                    Purchase_Method_Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Purchase__C3A06947C1DE8EB5", x => x.Purchase_Method);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_Users = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login_User = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Password_User = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USers__FB0668EED6E9345F", x => x.Id_Users);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_Product = table.Column<int>(type: "int", nullable: false),
                    Bar_Number = table.Column<int>(type: "int", nullable: false),
                    Description_Product = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Purchase_Method = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Offer_Price = table.Column<double>(type: "float", nullable: false),
                    IsReturned = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Product__6B19B3E7F5DD6746", x => x.Id_Product);
                    table.ForeignKey(
                        name: "FK__Product__Purchas__6CD828CA",
                        column: x => x.Purchase_Method,
                        principalTable: "Purchase_Methods",
                        principalColumn: "Purchase_Method");
                    table.ForeignKey(
                        name: "FK__Product__Type_Pr__3B40CD36",
                        column: x => x.Type_Product,
                        principalTable: "Product_Type",
                        principalColumn: "Type_Product");
                });

            migrationBuilder.CreateTable(
                name: "Buying_Price_Changing",
                columns: table => new
                {
                    Id_Price = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    Date_Price_Changed = table.Column<DateTime>(type: "datetime", nullable: false),
                    OldPrice = table.Column<double>(type: "float", nullable: false),
                    NewPrice = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Price_Ch__13FF7BF20F85FD58", x => x.Id_Price);
                    table.ForeignKey(
                        name: "FK__Price_Cha__Id_Pr__5CD6CB2B",
                        column: x => x.Id_Product,
                        principalTable: "Product",
                        principalColumn: "Id_Product");
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id_Purchase = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    Date_Purchase = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    From_Product_Create = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Purchase__DCFE25070AA2F635", x => x.Id_Purchase);
                    table.ForeignKey(
                        name: "FK__Purchase__Id_Pro__5FB337D6",
                        column: x => x.Id_Product,
                        principalTable: "Product",
                        principalColumn: "Id_Product");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id_Sales = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Sales = table.Column<DateTime>(type: "datetime", nullable: false),
                    Profit = table.Column<double>(type: "float", nullable: false),
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sales__0760C391D08180C5", x => x.Id_Sales);
                    table.ForeignKey(
                        name: "FK__Sales__Id_Produc__49C3F6B7",
                        column: x => x.Id_Product,
                        principalTable: "Product",
                        principalColumn: "Id_Product");
                });

            migrationBuilder.CreateTable(
                name: "Selling_Price_Changing",
                columns: table => new
                {
                    Id_Price = table.Column<int>(type: "int", nullable: false),
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    Date_Price_Changed = table.Column<DateTime>(type: "datetime", nullable: false),
                    OldPrice = table.Column<int>(type: "int", nullable: false),
                    NewPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Selling___13FF7BF2E1F64CD5", x => x.Id_Price);
                    table.ForeignKey(
                        name: "FK__Selling_P__Id_Pr__5CD6CB2B",
                        column: x => x.Id_Product,
                        principalTable: "Product",
                        principalColumn: "Id_Product");
                });

            migrationBuilder.CreateTable(
                name: "Returns",
                columns: table => new
                {
                    Id_Returns = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Sales = table.Column<int>(type: "int", nullable: false),
                    Date_Returns = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Returns__961EDEEDF8F6ACC8", x => x.Id_Returns);
                    table.ForeignKey(
                        name: "FK__Returns__Id_Sale__59FA5E80",
                        column: x => x.Id_Sales,
                        principalTable: "Sales",
                        principalColumn: "Id_Sales");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buying_Price_Changing_Id_Product",
                table: "Buying_Price_Changing",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Purchase_Method",
                table: "Product",
                column: "Purchase_Method");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Type_Product",
                table: "Product",
                column: "Type_Product");

            migrationBuilder.CreateIndex(
                name: "UQ__Product___41917908A52B8715",
                table: "Product_Type",
                column: "Product_Type_Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_Id_Product",
                table: "Purchase",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "UQ__Purchase__7E84CDA8C02FA8B3",
                table: "Purchase_Methods",
                column: "Purchase_Method_Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Returns_Id_Sales",
                table: "Returns",
                column: "Id_Sales");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Id_Product",
                table: "Sales",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Selling_Price_Changing_Id_Product",
                table: "Selling_Price_Changing",
                column: "Id_Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buying_Price_Changing");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Returns");

            migrationBuilder.DropTable(
                name: "Selling_Price_Changing");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Purchase_Methods");

            migrationBuilder.DropTable(
                name: "Product_Type");
        }
    }
}
