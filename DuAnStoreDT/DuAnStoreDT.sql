USE [master]
GO
/****** Object:  Database [DuAnStoreDT]    Script Date: 9/22/2023 11:33:48 AM ******/
CREATE DATABASE [DuAnStoreDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DuAnStoreDT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DuAnStoreDT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DuAnStoreDT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DuAnStoreDT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DuAnStoreDT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DuAnStoreDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DuAnStoreDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DuAnStoreDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DuAnStoreDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DuAnStoreDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DuAnStoreDT] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DuAnStoreDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET RECOVERY FULL 
GO
ALTER DATABASE [DuAnStoreDT] SET  MULTI_USER 
GO
ALTER DATABASE [DuAnStoreDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DuAnStoreDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DuAnStoreDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DuAnStoreDT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DuAnStoreDT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DuAnStoreDT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DuAnStoreDT', N'ON'
GO
ALTER DATABASE [DuAnStoreDT] SET QUERY_STORE = OFF
GO
USE [DuAnStoreDT]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[useradmin] [nvarchar](450) NOT NULL,
	[passwordadmin] [nvarchar](max) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[useradmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiTietHoaDonBans]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHoaDonBans](
	[macthdb] [nvarchar](450) NOT NULL,
	[masp] [nvarchar](450) NULL,
	[dongiaban] [int] NOT NULL,
	[soluong] [int] NOT NULL,
 CONSTRAINT [PK_chiTietHoaDonBans] PRIMARY KEY CLUSTERED 
(
	[macthdb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiTietHoaDonMuas]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHoaDonMuas](
	[macthdm] [nvarchar](450) NOT NULL,
	[masp] [nvarchar](450) NULL,
	[dongiamua] [int] NOT NULL,
	[soluong] [int] NOT NULL,
 CONSTRAINT [PK_chiTietHoaDonMuas] PRIMARY KEY CLUSTERED 
(
	[macthdm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucs]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucs](
	[madm] [nvarchar](450) NOT NULL,
	[tendm] [nvarchar](max) NULL,
 CONSTRAINT [PK_DanhMucs] PRIMARY KEY CLUSTERED 
(
	[madm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCaps]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCaps](
	[mancc] [nvarchar](450) NOT NULL,
	[tenncc] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhaCungCaps] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPhams]    Script Date: 9/22/2023 11:33:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPhams](
	[masp] [nvarchar](450) NOT NULL,
	[tensp] [nvarchar](max) NULL,
	[giacu] [int] NOT NULL,
	[giamoi] [int] NOT NULL,
	[hinhanh] [nvarchar](max) NULL,
	[madm] [nvarchar](450) NULL,
	[mancc] [nvarchar](450) NULL,
 CONSTRAINT [PK_SanPhams] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230921130826_AddTableAdmin', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230921131239_SeedDataAdminTable', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922034058_AddAll', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922034541_SeedDataAdmin_DMuc_NCC', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922035946_SeedDataSanPham', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922041447_UpdateDataSanPham', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922041810_SeedDataChiTietHDM_CTHDB', N'5.0.17')
GO
INSERT [dbo].[Admin] ([useradmin], [passwordadmin]) VALUES (N'admin1', N'admin1')
INSERT [dbo].[Admin] ([useradmin], [passwordadmin]) VALUES (N'admin2', N'admin2')
GO
INSERT [dbo].[chiTietHoaDonBans] ([macthdb], [masp], [dongiaban], [soluong]) VALUES (N'CTB01', N'SP01', 22990000, 1)
INSERT [dbo].[chiTietHoaDonBans] ([macthdb], [masp], [dongiaban], [soluong]) VALUES (N'CTB02', N'SP02', 17000000, 1)
INSERT [dbo].[chiTietHoaDonBans] ([macthdb], [masp], [dongiaban], [soluong]) VALUES (N'CTB03', N'SP06', 17000000, 1)
INSERT [dbo].[chiTietHoaDonBans] ([macthdb], [masp], [dongiaban], [soluong]) VALUES (N'CTB04', N'SP07', 17000000, 1)
GO
INSERT [dbo].[chiTietHoaDonMuas] ([macthdm], [masp], [dongiamua], [soluong]) VALUES (N'CTM01', N'SP01', 21990000, 5)
INSERT [dbo].[chiTietHoaDonMuas] ([macthdm], [masp], [dongiamua], [soluong]) VALUES (N'CTM02', N'SP02', 10000000, 7)
INSERT [dbo].[chiTietHoaDonMuas] ([macthdm], [masp], [dongiamua], [soluong]) VALUES (N'CTM03', N'SP06', 13000000, 6)
INSERT [dbo].[chiTietHoaDonMuas] ([macthdm], [masp], [dongiamua], [soluong]) VALUES (N'CTM04', N'SP07', 16000000, 4)
GO
INSERT [dbo].[DanhMucs] ([madm], [tendm]) VALUES (N'DM1', N'Điện thoại')
INSERT [dbo].[DanhMucs] ([madm], [tendm]) VALUES (N'DM2', N'Laptop')
INSERT [dbo].[DanhMucs] ([madm], [tendm]) VALUES (N'DM3', N'Tai nghe')
GO
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NAP', N'APPLE')
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NAS', N'ASUS')
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NLN', N'LENOVO')
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NMA', N'MAC')
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NOP', N'OPPO')
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NSN', N'SONY')
INSERT [dbo].[NhaCungCaps] ([mancc], [tenncc]) VALUES (N'NSS', N'SAMSUNG')
GO
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP01', N'Samsung Galaxy S23 Ultra 256GB', 31990000, 22990000, N'img_StoreDienThoai\7.jpg', N'DM1', N'NSS')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP02', N'Samsung Galaxy A54 5G 8GB 128GB', 20990000, 17000000, N'img_StoreDienThoai\9.jpg', N'DM1', N'NSS')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP03', N'iPhone 13 Pro Max 128GB | Chính hãng VN/A', 50990000, 47000000, N'img_StoreDienThoai\1.jpg', N'DM1', N'NAP')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP04', N'iPhone 13 Pro Max 128GB | Chính hãng VN/A', 50990000, 47000000, N'img_StoreDienThoai\1.jpg', N'DM1', N'NAP')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP05', N'iPhone 13 Pro Max 128GB | Chính hãng VN/A', 50990000, 47000000, N'img_StoreDienThoai\1.jpg', N'DM1', N'NAP')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP06', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP07', N'Laptop ASUS TUF Gaming F15 FX506HC-HN144W', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NAS')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP08', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP09', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP10', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP11', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP12', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP13', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP14', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP15', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP16', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
INSERT [dbo].[SanPhams] ([masp], [tensp], [giacu], [giamoi], [hinhanh], [madm], [mancc]) VALUES (N'SP17', N'Laptop Lenovo Gaming Legion 5 15ARH7 82RE002VVN', 26990000, 17000000, N'img_StoreDienThoai\15.jpg', N'DM2', N'NLN')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_chiTietHoaDonBans_masp]    Script Date: 9/22/2023 11:33:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_chiTietHoaDonBans_masp] ON [dbo].[chiTietHoaDonBans]
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_chiTietHoaDonMuas_masp]    Script Date: 9/22/2023 11:33:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_chiTietHoaDonMuas_masp] ON [dbo].[chiTietHoaDonMuas]
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SanPhams_madm]    Script Date: 9/22/2023 11:33:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_SanPhams_madm] ON [dbo].[SanPhams]
(
	[madm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SanPhams_mancc]    Script Date: 9/22/2023 11:33:48 AM ******/
CREATE NONCLUSTERED INDEX [IX_SanPhams_mancc] ON [dbo].[SanPhams]
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[chiTietHoaDonBans]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHoaDonBans_SanPhams_masp] FOREIGN KEY([masp])
REFERENCES [dbo].[SanPhams] ([masp])
GO
ALTER TABLE [dbo].[chiTietHoaDonBans] CHECK CONSTRAINT [FK_chiTietHoaDonBans_SanPhams_masp]
GO
ALTER TABLE [dbo].[chiTietHoaDonMuas]  WITH CHECK ADD  CONSTRAINT [FK_chiTietHoaDonMuas_SanPhams_masp] FOREIGN KEY([masp])
REFERENCES [dbo].[SanPhams] ([masp])
GO
ALTER TABLE [dbo].[chiTietHoaDonMuas] CHECK CONSTRAINT [FK_chiTietHoaDonMuas_SanPhams_masp]
GO
ALTER TABLE [dbo].[SanPhams]  WITH CHECK ADD  CONSTRAINT [FK_SanPhams_DanhMucs_madm] FOREIGN KEY([madm])
REFERENCES [dbo].[DanhMucs] ([madm])
GO
ALTER TABLE [dbo].[SanPhams] CHECK CONSTRAINT [FK_SanPhams_DanhMucs_madm]
GO
ALTER TABLE [dbo].[SanPhams]  WITH CHECK ADD  CONSTRAINT [FK_SanPhams_NhaCungCaps_mancc] FOREIGN KEY([mancc])
REFERENCES [dbo].[NhaCungCaps] ([mancc])
GO
ALTER TABLE [dbo].[SanPhams] CHECK CONSTRAINT [FK_SanPhams_NhaCungCaps_mancc]
GO
USE [master]
GO
ALTER DATABASE [DuAnStoreDT] SET  READ_WRITE 
GO
