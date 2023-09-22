﻿// <auto-generated />
using DuAnStoreDT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DuAnStoreDT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230922035946_SeedDataSanPham")]
    partial class SeedDataSanPham
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DuAnStoreDT.Models.Admin", b =>
                {
                    b.Property<string>("useradmin")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("passwordadmin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("useradmin");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            useradmin = "admin1",
                            passwordadmin = "admin1"
                        },
                        new
                        {
                            useradmin = "admin2",
                            passwordadmin = "admin2"
                        });
                });

            modelBuilder.Entity("DuAnStoreDT.Models.ChiTietHoaDonBan", b =>
                {
                    b.Property<string>("macthdb")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("dongiaban")
                        .HasColumnType("int");

                    b.Property<string>("masp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.HasKey("macthdb");

                    b.HasIndex("masp");

                    b.ToTable("chiTietHoaDonBans");
                });

            modelBuilder.Entity("DuAnStoreDT.Models.ChiTietHoaDonMua", b =>
                {
                    b.Property<string>("macthdm")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("dongiamua")
                        .HasColumnType("int");

                    b.Property<string>("masp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.HasKey("macthdm");

                    b.HasIndex("masp");

                    b.ToTable("chiTietHoaDonMuas");
                });

            modelBuilder.Entity("DuAnStoreDT.Models.DanhMuc", b =>
                {
                    b.Property<string>("madm")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tendm")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("madm");

                    b.ToTable("DanhMucs");

                    b.HasData(
                        new
                        {
                            madm = "DM1",
                            tendm = "Điện thoại"
                        },
                        new
                        {
                            madm = "DM2",
                            tendm = "Laptop"
                        },
                        new
                        {
                            madm = "DM3",
                            tendm = "Tai nghe"
                        });
                });

            modelBuilder.Entity("DuAnStoreDT.Models.NhaCungCap", b =>
                {
                    b.Property<string>("mancc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tenncc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mancc");

                    b.ToTable("NhaCungCaps");

                    b.HasData(
                        new
                        {
                            mancc = "NSS",
                            tenncc = "SAMSUNG"
                        },
                        new
                        {
                            mancc = "NAP",
                            tenncc = "APPLE"
                        },
                        new
                        {
                            mancc = "NOP",
                            tenncc = "OPPO"
                        },
                        new
                        {
                            mancc = "NLN",
                            tenncc = "LENOVO"
                        },
                        new
                        {
                            mancc = "NMA",
                            tenncc = "MAC"
                        },
                        new
                        {
                            mancc = "NAS",
                            tenncc = "ASUS"
                        },
                        new
                        {
                            mancc = "NSN",
                            tenncc = "SONY"
                        });
                });

            modelBuilder.Entity("DuAnStoreDT.Models.SanPham", b =>
                {
                    b.Property<string>("masp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("giacu")
                        .HasColumnType("int");

                    b.Property<int>("giamoi")
                        .HasColumnType("int");

                    b.Property<string>("hinhanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("madm")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("mancc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tensp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("masp");

                    b.HasIndex("madm");

                    b.HasIndex("mancc");

                    b.ToTable("SanPhams");

                    b.HasData(
                        new
                        {
                            masp = "SP01",
                            giacu = 31990000,
                            giamoi = 22990000,
                            hinhanh = "img_StoreDienThoai\\7.jpg",
                            madm = "DM1",
                            mancc = "NSS",
                            tensp = "Samsung Galaxy S23 Ultra 256GB"
                        },
                        new
                        {
                            masp = "SP02",
                            giacu = 20990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\9.jpg",
                            madm = "DM1",
                            mancc = "NSS",
                            tensp = "Samsung Galaxy A54 5G 8GB 128GB"
                        },
                        new
                        {
                            masp = "SP03",
                            giacu = 50990000,
                            giamoi = 47000000,
                            hinhanh = "img_StoreDienThoai\\1.jpg",
                            madm = "DM1",
                            mancc = "NSS",
                            tensp = "iPhone 13 Pro Max 128GB | Chính hãng VN/A"
                        },
                        new
                        {
                            masp = "SP04",
                            giacu = 50990000,
                            giamoi = 47000000,
                            hinhanh = "img_StoreDienThoai\\1.jpg",
                            madm = "DM1",
                            mancc = "NSS",
                            tensp = "iPhone 13 Pro Max 128GB | Chính hãng VN/A"
                        },
                        new
                        {
                            masp = "SP05",
                            giacu = 50990000,
                            giamoi = 47000000,
                            hinhanh = "img_StoreDienThoai\\1.jpg",
                            madm = "DM1",
                            mancc = "NSS",
                            tensp = "iPhone 13 Pro Max 128GB | Chính hãng VN/A"
                        },
                        new
                        {
                            masp = "SP06",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP07",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop ASUS TUF Gaming F15 FX506HC-HN144W"
                        },
                        new
                        {
                            masp = "SP08",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP09",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP10",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP11",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP12",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP13",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP14",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP15",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP16",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        },
                        new
                        {
                            masp = "SP17",
                            giacu = 26990000,
                            giamoi = 17000000,
                            hinhanh = "img_StoreDienThoai\\15.jpg",
                            madm = "DM2",
                            mancc = "NSS",
                            tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN"
                        });
                });

            modelBuilder.Entity("DuAnStoreDT.Models.ChiTietHoaDonBan", b =>
                {
                    b.HasOne("DuAnStoreDT.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("masp");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DuAnStoreDT.Models.ChiTietHoaDonMua", b =>
                {
                    b.HasOne("DuAnStoreDT.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("masp");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DuAnStoreDT.Models.SanPham", b =>
                {
                    b.HasOne("DuAnStoreDT.Models.DanhMuc", "DanhMuc")
                        .WithMany()
                        .HasForeignKey("madm");

                    b.HasOne("DuAnStoreDT.Models.NhaCungCap", "NhaCungCap")
                        .WithMany()
                        .HasForeignKey("mancc");

                    b.Navigation("DanhMuc");

                    b.Navigation("NhaCungCap");
                });
#pragma warning restore 612, 618
        }
    }
}
