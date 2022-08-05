using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeApp.DAL.Migrations
{
    public partial class ChangeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Customer_CustomerId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_CustomerId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customer",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "Customer",
                newName: "Mail");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderId",
                table: "Order",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customer",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Customer",
                newName: "mail");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Item_CustomerId",
                table: "Item",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Customer_CustomerId",
                table: "Item",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
