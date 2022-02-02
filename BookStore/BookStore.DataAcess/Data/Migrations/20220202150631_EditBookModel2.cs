using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DataAcess.Migrations
{
    public partial class EditBookModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferingPrice",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "PurchasePrice",
                table: "Books",
                newName: "Price");

            migrationBuilder.AddColumn<int>(
                name: "DiscountRate",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountRate",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Books",
                newName: "PurchasePrice");

            migrationBuilder.AddColumn<double>(
                name: "OfferingPrice",
                table: "Books",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
