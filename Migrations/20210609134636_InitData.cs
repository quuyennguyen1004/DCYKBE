using Microsoft.EntityFrameworkCore.Migrations;

namespace Webtt.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Dụng Cụ Chuyên Khoa" },
                    { 2, "Dụng Cụ Tập Đi" },
                    { 3, "Dụng Cụ Thẩm Mỹ" },
                    { 4, "Dụng Cụ Trị Liệu" },
                    { 5, "Dụng Cụ Y Tế INOX" },
                    { 6, "Đai Nẹp Y Tế" },
                    { 7, "Đèn Y Khoa" },
                    { 8, "Máy Móc Y Khoa" },
                    { 9, "Mẹ và Bé" },
                    { 10, "Trang Thiết Bị Y Khoa" },
                    { 11, "Vật Tư Y Tế Tiêu Hao" },
                    { 12, "Vớ Y Khoa-Vớ Giãn Tĩnh Mạch" },
                    { 13, "Sản Phẩm Mới" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ProductImage", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 2, 1, "Máy đo thân nhiệt thế hệ mới", "chuyenkhoa.jpg", "Máy đo thân nhiệt", 250.0 },
                    { 3, 2, "Dụng cụ tập đi cho những người bị tật", "tapdi.jpg", "Xe tập đi", 700.0 },
                    { 4, 3, "Bộ trang thiết bị thẩm mỹ hiện đại nhất", "thammy.jpg", "Máy thẩm mỹ", 1205.0 },
                    { 5, 4, "Ghế Gập Tay-Chân(Ba trong Một)", "trịlieu.jpg", "Ghế Gập Tay-Chân", 2400.0 },
                    { 6, 5, "Dùng để đựng dụng cụ y tế", "inox.jpg", "Hộp đựng dụng cụ Inox", 50.0 },
                    { 7, 6, "Đai nẹp cổ thoáng khí Breathable Neck support", "dainep.jpg", "Đai nẹp cổ", 460.0 },
                    { 8, 7, "Sử dụng phương pháp nhiệt đơn sắc, hỗ trợ kháng khuẩn, nấm.... ", "den.jpg", "Đèn Hồng Ngoại y Tế", 390.0 },
                    { 9, 8, "Giúp chẩn đoán nhanh hơn", "maymoc.jpg", "Máy chụp CT scanner", 15000.0 },
                    { 10, 9, "Bao gồm: Bộ hút đàm, Cặp nhiệt độ điện tử, ống hút thuốc", "treem.jpg", "Bộ dụng cụ ý tế trẻ em", 350.0 },
                    { 11, 10, "Khẩu trang y tế 3D kháng khuẩn 4 lớp màng lọc n95", "trangtb.jpg", "Khẩu trang Y tế", 50.0 },
                    { 12, 11, "Kích thước 1m8 x 0,0085/cuộn. Bịch 5 cuộn", "tieuhao.jpg", "Băng cuộn Y tế", 20.0 },
                    { 13, 12, "Làm giảm đường kính các tĩnh mạch ngăn máu chảy ngược xuống...", "vo.jpg", "Vớ y khoa điều trị suy giãn tĩnh mạch", 380.0 },
                    { 1, 13, "Xe tiện dụng", "xe-tiem-thuoc-30x40-2-tang1561266976.jpg", "Xe Tiêm 30*40 2 tầng hai vòng thâu", 500.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
