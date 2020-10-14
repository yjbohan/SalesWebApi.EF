﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebApi.EF.Migrations
{
    public partial class addOrderline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orderline",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orderline_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orderline_OrderId",
                table: "Orderline",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orderline");
        }
    }
}
