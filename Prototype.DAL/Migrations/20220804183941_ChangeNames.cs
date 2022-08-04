using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeApp.DAL.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Books_CustomerId",
                table: "BookCopies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "BookCopies",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_CustomerId",
                table: "Item",
                newName: "IX_Item_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Customer_CustomerId",
                table: "Item",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Customer_CustomerId",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "BookCopies");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Item_CustomerId",
                table: "BookCopies",
                newName: "IX_BookCopies_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Books_CustomerId",
                table: "BookCopies",
                column: "CustomerId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
