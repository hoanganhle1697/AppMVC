using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_DanhMucs_CategoryID",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DanhMucs",
                table: "DanhMucs");

            migrationBuilder.RenameTable(
                name: "SanPhams",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "DanhMucs",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhams_CategoryID",
                table: "Products",
                newName: "IX_Products_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "SanPhams");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "DanhMucs");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryID",
                table: "SanPhams",
                newName: "IX_SanPhams_CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DanhMucs",
                table: "DanhMucs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_DanhMucs_CategoryID",
                table: "SanPhams",
                column: "CategoryID",
                principalTable: "DanhMucs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
