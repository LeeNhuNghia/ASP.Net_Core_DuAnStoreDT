using Microsoft.EntityFrameworkCore.Migrations;

namespace DuAnStoreDT.Migrations
{
    public partial class AddAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "useradmin",
                keyValue: "admin1");

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "useradmin",
                keyValue: "admin2");

            migrationBuilder.CreateTable(
                name: "DanhMucs",
                columns: table => new
                {
                    madm = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tendm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucs", x => x.madm);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    mancc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenncc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.mancc);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    masp = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tensp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giacu = table.Column<int>(type: "int", nullable: false),
                    giamoi = table.Column<int>(type: "int", nullable: false),
                    hinhanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    madm = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    mancc = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.masp);
                    table.ForeignKey(
                        name: "FK_SanPhams_DanhMucs_madm",
                        column: x => x.madm,
                        principalTable: "DanhMucs",
                        principalColumn: "madm",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhams_NhaCungCaps_mancc",
                        column: x => x.mancc,
                        principalTable: "NhaCungCaps",
                        principalColumn: "mancc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "chiTietHoaDonBans",
                columns: table => new
                {
                    macthdb = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    masp = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dongiaban = table.Column<int>(type: "int", nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietHoaDonBans", x => x.macthdb);
                    table.ForeignKey(
                        name: "FK_chiTietHoaDonBans_SanPhams_masp",
                        column: x => x.masp,
                        principalTable: "SanPhams",
                        principalColumn: "masp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "chiTietHoaDonMuas",
                columns: table => new
                {
                    macthdm = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    masp = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dongiamua = table.Column<int>(type: "int", nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietHoaDonMuas", x => x.macthdm);
                    table.ForeignKey(
                        name: "FK_chiTietHoaDonMuas_SanPhams_masp",
                        column: x => x.masp,
                        principalTable: "SanPhams",
                        principalColumn: "masp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chiTietHoaDonBans_masp",
                table: "chiTietHoaDonBans",
                column: "masp");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietHoaDonMuas_masp",
                table: "chiTietHoaDonMuas",
                column: "masp");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_madm",
                table: "SanPhams",
                column: "madm");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_mancc",
                table: "SanPhams",
                column: "mancc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietHoaDonBans");

            migrationBuilder.DropTable(
                name: "chiTietHoaDonMuas");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "DanhMucs");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "useradmin", "passwordadmin" },
                values: new object[] { "admin1", "admin1" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "useradmin", "passwordadmin" },
                values: new object[] { "admin2", "admin2" });
        }
    }
}
