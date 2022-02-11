using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DataAcess.Migrations
{
    public partial class UpdateCartKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartId",
                table: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartId",
                table: "Carts",
                columns: new[] { "CartId", "BookId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CartId",
                table: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartId",
                table: "Carts",
                column: "CartId");
        }
    }
}
