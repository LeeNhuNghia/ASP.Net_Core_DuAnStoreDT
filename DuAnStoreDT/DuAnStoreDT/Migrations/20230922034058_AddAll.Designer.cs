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
    [Migration("20230922034058_AddAll")]
    partial class AddAll
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
                });

            modelBuilder.Entity("DuAnStoreDT.Models.NhaCungCap", b =>
                {
                    b.Property<string>("mancc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tenncc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mancc");

                    b.ToTable("NhaCungCaps");
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
