using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DuAnStoreDT.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietHoaDonMua> chiTietHoaDonMuas { get; set; }
        public DbSet<ChiTietHoaDonBan> chiTietHoaDonBans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin { useradmin = "admin1", passwordadmin = "admin1" },
                new Admin { useradmin = "admin2", passwordadmin = "admin2" });

            modelBuilder.Entity<DanhMuc>().HasData(
                new DanhMuc { madm = "DM1", tendm = "Điện thoại" },
                new DanhMuc { madm = "DM2", tendm = "Laptop" },
                new DanhMuc { madm = "DM3", tendm = "Tai nghe" });

            modelBuilder.Entity<NhaCungCap>().HasData(
                new NhaCungCap { mancc = "NSS", tenncc = "SAMSUNG" },
                new NhaCungCap { mancc = "NAP", tenncc = "APPLE" },
                new NhaCungCap { mancc = "NOP", tenncc = "OPPO" },
                new NhaCungCap { mancc = "NLN", tenncc = "LENOVO" },
                new NhaCungCap { mancc = "NMA", tenncc = "MAC" },
                new NhaCungCap { mancc = "NAS", tenncc = "ASUS" },
                new NhaCungCap { mancc = "NSN", tenncc = "SONY" });

            modelBuilder.Entity<SanPham>().HasData(
                new SanPham { masp = "SP01", tensp = "Samsung Galaxy S23 Ultra 256GB", giacu = 31990000, giamoi = 22990000, hinhanh = @"img_StoreDienThoai\7.jpg", madm = "DM1", mancc = "NSS" },
                new SanPham { masp = "SP02", tensp = "Samsung Galaxy A54 5G 8GB 128GB", giacu = 20990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\9.jpg", madm = "DM1", mancc = "NSS" },
                new SanPham { masp = "SP03", tensp = "iPhone 13 Pro Max 128GB | Chính hãng VN/A", giacu = 50990000, giamoi = 47000000, hinhanh = @"img_StoreDienThoai\1.jpg", madm = "DM1", mancc = "NAP" },
                new SanPham { masp = "SP04", tensp = "iPhone 13 Pro Max 128GB | Chính hãng VN/A", giacu = 50990000, giamoi = 47000000, hinhanh = @"img_StoreDienThoai\1.jpg", madm = "DM1", mancc = "NAP" },
                new SanPham { masp = "SP05", tensp = "iPhone 13 Pro Max 128GB | Chính hãng VN/A", giacu = 50990000, giamoi = 47000000, hinhanh = @"img_StoreDienThoai\1.jpg", madm = "DM1", mancc = "NAP" },
                new SanPham { masp = "SP06", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP07", tensp = "Laptop ASUS TUF Gaming F15 FX506HC-HN144W", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NAS" },
                new SanPham { masp = "SP08", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP09", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP10", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP11", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP12", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP13", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP14", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP15", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP16", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" },
                new SanPham { masp = "SP17", tensp = "Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN", giacu = 26990000, giamoi = 17000000, hinhanh = @"img_StoreDienThoai\15.jpg", madm = "DM2", mancc = "NLN" }
                );

            modelBuilder.Entity<ChiTietHoaDonMua>().HasData(
                new ChiTietHoaDonMua { macthdm = "CTM01", masp = "SP01", dongiamua = 21990000, soluong = 5 },
                new ChiTietHoaDonMua { macthdm = "CTM02", masp = "SP02", dongiamua = 10000000, soluong = 7 },
                new ChiTietHoaDonMua { macthdm = "CTM03", masp = "SP06", dongiamua = 13000000, soluong = 6 },
                new ChiTietHoaDonMua { macthdm = "CTM04", masp = "SP07", dongiamua = 16000000, soluong = 4 }
                );

            modelBuilder.Entity<ChiTietHoaDonBan>().HasData(
                new ChiTietHoaDonBan { macthdb = "CTB01", masp = "SP01", dongiaban = 22990000, soluong = 1 },
                new ChiTietHoaDonBan { macthdb = "CTB02", masp = "SP02", dongiaban = 17000000, soluong = 1 },
                new ChiTietHoaDonBan { macthdb = "CTB03", masp = "SP06", dongiaban = 17000000, soluong = 1 },
                new ChiTietHoaDonBan { macthdb = "CTB04", masp = "SP07", dongiaban = 17000000, soluong = 1 }
                );
        }   
    }
}
