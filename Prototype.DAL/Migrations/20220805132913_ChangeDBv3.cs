using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeApp.DAL.Migrations
{
    public partial class ChangeDBv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Order_OrderId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_OrderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityAvailable",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "itemId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_itemId",
                table: "Product",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderId",
                table: "Product",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Item_itemId",
                table: "Product",
                column: "itemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Item_itemId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_itemId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_OrderId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "QuantityAvailable",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "itemId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderId",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Order_OrderId",
                table: "Order",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }
    }
}
