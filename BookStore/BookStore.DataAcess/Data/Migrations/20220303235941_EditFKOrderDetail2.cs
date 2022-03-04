using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DataAcess.Migrations
{
    public partial class EditFKOrderDetail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookOrderDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetailBookId",
                table: "OrderDetails",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetailBookId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_BookId",
                table: "OrderDetails");

            migrationBuilder.CreateTable(
                name: "BookOrderDetail",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailsOrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailsBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailsOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrderDetail", x => new { x.BookId, x.OrderDetailsOrderDetailId, x.OrderDetailsBookId, x.OrderDetailsOrderId });
                    table.ForeignKey(
                        name: "FK_BookOrderDetail_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrderDetail_OrderDetails_OrderDetailsOrderDetailId_OrderDetailsBookId_OrderDetailsOrderId",
                        columns: x => new { x.OrderDetailsOrderDetailId, x.OrderDetailsBookId, x.OrderDetailsOrderId },
                        principalTable: "OrderDetails",
                        principalColumns: new[] { "OrderDetailId", "BookId", "OrderId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookOrderDetail_OrderDetailsOrderDetailId_OrderDetailsBookId_OrderDetailsOrderId",
                table: "BookOrderDetail",
                columns: new[] { "OrderDetailsOrderDetailId", "OrderDetailsBookId", "OrderDetailsOrderId" });
        }
    }
}
