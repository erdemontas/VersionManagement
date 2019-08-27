using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VersionManagement.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId1",
                table: "Component",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Component_ProductId1",
                table: "Component",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Component_Product_ProductId1",
                table: "Component",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Component_Product_ProductId1",
                table: "Component");

            migrationBuilder.DropIndex(
                name: "IX_Component_ProductId1",
                table: "Component");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Component");
        }
    }
}
