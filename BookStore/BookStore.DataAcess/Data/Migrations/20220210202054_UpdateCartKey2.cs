using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DataAcess.Migrations
{
    public partial class UpdateCartKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartId",
                table: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartId",
                table: "Carts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Books_BookId",
                table: "Carts",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Books_BookId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartId",
                table: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartId",
                table: "Carts",
                columns: new[] { "CartId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookId",
                table: "Carts",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
