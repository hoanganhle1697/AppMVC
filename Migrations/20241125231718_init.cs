using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMucs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhams_DanhMucs_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "DanhMucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DanhMucs",
                columns: new[] { "Id", "TenDanhMuc" },
                values: new object[,]
                {
                    { 1, "Laptop" },
                    { 2, "Điện Thoại" },
                    { 3, "Đồng Hồ Thông Minh" },
                    { 4, "Tai Nghe" },
                    { 5, "Máy Ảnh" },
                    { 6, "Tivi" }
                });

            migrationBuilder.InsertData(
                table: "SanPhams",
                columns: new[] { "Id", "CategoryID", "Gia", "HinhAnh", "MoTa", "Slug", "TenSP" },
                values: new object[,]
                {
                    { 1, 1, 20000000m, "dell-inspiron.jpg", "Laptop Dell hiệu suất cao, phù hợp cho công việc.", "laptop-dell-inspiron", "Laptop Dell Inspiron" },
                    { 2, 2, 25000000m, "iphone-14.jpg", "iPhone 14 với công nghệ camera tiên tiến.", "dien-thoai-iphone-14", "Điện Thoại iPhone 14" },
                    { 3, 3, 6000000m, "galaxy-watch.jpg", "Đồng hồ thông minh với các tính năng sức khỏe.", "smartwatch-samsung-galaxy-watch", "Smartwatch Samsung Galaxy Watch" },
                    { 4, 4, 8500000m, "sony-wh-1000xm5.jpg", "Tai nghe chống ồn cao cấp từ Sony.", "tai-nghe-sony-wh-1000xm5", "Tai Nghe Sony WH-1000XM5" },
                    { 5, 5, 32000000m, "canon-eos-r10.jpg", "Máy ảnh mirrorless nhỏ gọn, chất lượng cao.", "may-anh-canon-eos-r10", "Máy Ảnh Canon EOS R10" },
                    { 6, 6, 45000000m, "lg-oled-c3.jpg", "Tivi OLED với công nghệ hình ảnh vượt trội.", "tivi-lg-oled-c3", "Tivi LG OLED C3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_CategoryID",
                table: "SanPhams",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "DanhMucs");
        }
    }
}
