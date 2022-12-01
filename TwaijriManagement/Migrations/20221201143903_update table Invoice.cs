using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwaijriManagement.Migrations
{
    public partial class updatetableInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_CustomerId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Invoices",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                newName: "IX_Invoices_CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customers_CustomerID",
                table: "Invoices",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Customers_CustomerID",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Invoices",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_CustomerID",
                table: "Invoices",
                newName: "IX_Invoices_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Customers_CustomerId",
                table: "Invoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
