USE [master]
GO
--drop database QuanLyNhanSu1
/****** Object:  Database [QuanLyNhanSu1]    Script Date: 4/27/2021 10:53:35 AM ******/
CREATE DATABASE [QuanLyNhanSu1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhanSu1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyNhanSu1.MDF' , SIZE = 102400KB , MAXSIZE = 1048576KB , FILEGROWTH = 10240KB )
 LOG ON 
( NAME = N'QuanLyNhanSu1_LOG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyNhanSu1_LOG.LDF' , SIZE = 204800KB , MAXSIZE = 2048GB , FILEGROWTH = 20480KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyNhanSu1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhanSu1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu1] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyNhanSu1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyNhanSu1] SET QUERY_STORE = OFF
GO
USE [QuanLyNhanSu1]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[TenDN] [nchar](10) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[MaNV] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDLD]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDLD](
	[MaNV] [nchar](10) NULL,
	[TenHD] [nvarchar](50) NULL,
	[NgayKiHopDong] [date] NULL,
	[NgayKetThucKiHopDong] [date] NULL,
	[MaHD] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[MaNV] [nchar](10) NULL,
	[LuongCB] [int] NULL,
	[LuongThuong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoNgayTangCa] [char](5) NULL,
	[TongLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[BangCap] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[MaPB] [nchar](10) NULL,
	[CMTND] [nchar](20) NULL,
	[SDT] [nchar](11) NULL,
	[DanToc] [nvarchar](11) NULL,
	[TonGiao] [nvarchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_CHUCVU]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_CHUCVU](
	[MaCV] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_VITRI]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_VITRI](
	[MaVT] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPB] [nchar](10) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaTP] [nchar](10) NULL,
	[TenTP] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VITRICONGVIEC]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VITRICONGVIEC](
	[MaVT] [nchar](10) NOT NULL,
	[TenVT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV1       ', N'Giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV2       ', N'Trưởng Phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV3       ', N'Phó Phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV4       ', N'')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV5       ', N'')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV6       ', N'')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV7       ', N'')
GO
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV01      ', N'nv01123', N'NV01      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV03      ', N'nv03123', N'NV03      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV04      ', N'nv04123', N'NV04      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV05      ', N'nv05123', N'NV05      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'NV08      ', N'123', N'NV08      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPKT      ', N'444', N'NV01      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPMK      ', N'nv03123', N'NV03      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPNV      ', N'nv04123', N'NV04      ')
INSERT [dbo].[DANGNHAP] ([TenDN], [MatKhau], [MaNV]) VALUES (N'TPTC      ', N'nv05123', N'NV05      ')
GO
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV01      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-12-05' AS Date), CAST(N'2019-04-13' AS Date), N'HD01      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV02      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-11-07' AS Date), CAST(N'2016-11-07' AS Date), N'HD02      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV03      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2012-06-12' AS Date), CAST(N'2018-05-11' AS Date), N'HD03      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV04      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-08-13' AS Date), CAST(N'2018-08-13' AS Date), N'HD04      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV05      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-02-14' AS Date), CAST(N'2019-02-14' AS Date), N'HD05      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV06      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-03-15' AS Date), CAST(N'2020-03-15' AS Date), N'HD06      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV07      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2017-04-16' AS Date), CAST(N'2021-04-16' AS Date), N'HD07      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV08      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-05-17' AS Date), CAST(N'2022-05-17' AS Date), N'HD08      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV09      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-06-18' AS Date), CAST(N'2023-06-18' AS Date), N'HD09      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV10      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2010-07-19' AS Date), CAST(N'2024-07-19' AS Date), N'HD10      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV11      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-08-20' AS Date), CAST(N'2026-08-20' AS Date), N'HD11      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV12      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2015-09-21' AS Date), CAST(N'2025-09-21' AS Date), N'HD12      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV13      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2017-04-22' AS Date), CAST(N'2026-04-22' AS Date), N'HD13      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV14      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2018-08-23' AS Date), CAST(N'2027-08-23' AS Date), N'HD14      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV15      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2018-09-24' AS Date), CAST(N'2028-09-24' AS Date), N'HD15      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV16      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-04-25' AS Date), CAST(N'2029-04-25' AS Date), N'HD16      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV17      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2011-09-17' AS Date), CAST(N'2030-09-17' AS Date), N'HD17      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV18      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2013-06-18' AS Date), CAST(N'2031-06-18' AS Date), N'HD18      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV19      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2014-03-16' AS Date), CAST(N'2032-03-16' AS Date), N'HD19      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV20      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2016-02-14' AS Date), CAST(N'2033-02-14' AS Date), N'HD20      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV21      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2018-07-13' AS Date), CAST(N'2034-07-13' AS Date), N'HD21      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV22      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2019-09-11' AS Date), CAST(N'2035-09-11' AS Date), N'HD22      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV23      ', N'Hợp Đồng Có Thời Hạn', CAST(N'2010-11-15' AS Date), CAST(N'2030-11-15' AS Date), N'HD23      ')
INSERT [dbo].[HDLD] ([MaNV], [TenHD], [NgayKiHopDong], [NgayKetThucKiHopDong], [MaHD]) VALUES (N'NV24      ', N'Hợp Đồng có thời hạn', CAST(N'2019-05-14' AS Date), CAST(N'2029-05-14' AS Date), N'HD24      ')
GO
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV01      ', 7250000, 500000, N'tháng 10', N'5    ', 8000000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV02      ', 7000000, 700000, N'', N'4    ', 7900000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV03      ', 1000000, 1000000, N'thương tháng 5', N'1    ', 2050000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV04      ', 700000, 500000, N'', N'     ', 1200000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV05      ', 15000000, 300000, N'hợp đồng', N'5    ', 15550000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV06      ', 6000000, 700000, N'', N'5    ', 6950000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV07      ', 6500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV08      ', 8000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV09      ', 7000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV10      ', 6000000, 0, N'25325', N'     ', 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV11      ', 5000000, 500, N'', N'     ', 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV12      ', 5000000, 5000000, N'scfs', N'5    ', 0)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV13      ', 10000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV14      ', 6000000, 500000, N'kí hợp đồng mới', N'8    ', 6700000)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV15      ', 7500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV16      ', 7000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV17      ', 9000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV18      ', 10000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV19      ', 9000000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV20      ', 7500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV21      ', 6500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV22      ', 5500000, NULL, NULL, NULL, NULL)
INSERT [dbo].[LUONG] ([MaNV], [LuongCB], [LuongThuong], [GhiChu], [SoNgayTangCa], [TongLuong]) VALUES (N'NV23      ', 6500000, 0, N'', N'     ', 0)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV01      ', N'Nguyễn Hữu Chính', N'Đại Học', N'Nam  ', CAST(N'1994-09-07' AS Date), N'Bắc Giang', N'TC-KT     ', N'46364356457547      ', N'097854629  ', N'tày        ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV02      ', N'Nguyễn Minh Tú', N'Đại Học', N'Nam  ', CAST(N'1994-09-10' AS Date), N'Hà Nội', N'TC-KT     ', N'13123214599         ', N'098765324  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV03      ', N'Lê Trường Sơn', N'Tiến Sỹ', N'Nam  ', CAST(N'1993-05-07' AS Date), N'Yên Bái', N'MK        ', N'12334345465         ', N'098654353  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV04      ', N'Đặng Tuấn Anh', N'Đại Học', N'Nam  ', CAST(N'1994-09-07' AS Date), N'Hà Nội', N'NV        ', N'4545464565          ', N'016765484  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV05      ', N'Phạm Hải Nam', N'Thạc Sỹ', N'Nam  ', CAST(N'1994-09-07' AS Date), N'Quảng Ninh', N'KT-KT     ', N'45765857343         ', N'098643688  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV06      ', N'Nguyễn Minh Anh', N'Đại Học', N'Nữ   ', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'TC-KT     ', N'45653647547         ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV07      ', N'Nguyễn Ba Huy', N'Đại Học', N'Nam  ', CAST(N'1995-10-10' AS Date), N'Hà Nội', N'TC-KT     ', N'533532543           ', N'0987554444 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV08      ', N'Phạm Thị Hương', N'Tiến Sỹ', N'Nữ   ', CAST(N'1993-05-08' AS Date), N'Yên Bái', N'MK        ', N'436362              ', N'0987554444 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV09      ', N'Đặng Anh Vũ', N'Đại Học', N'Nam  ', CAST(N'1996-09-07' AS Date), N'Bắc Giang', N'NV        ', N'5345235             ', N'0987554444 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV10      ', N'Lê Hoàng Long', N'Thạc Sỹ', N'Nam  ', CAST(N'1991-09-07' AS Date), N'Quảng Nam', N'KT-KT     ', N'35324534543         ', N'0987554444 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV11      ', N'Đào Quang An', N'Đại Học', N'Nam  ', CAST(N'1992-02-07' AS Date), N'Bắc Giang', N'KT-KT     ', N'35435435325         ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV12      ', N'Nguyễn Phúc Vân Anh', N'Đại Học', N'Nữ   ', CAST(N'1994-10-07' AS Date), N'Hà Giang', N'TC-KT     ', N'353535345           ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV13      ', N'Mai Gia Bảo', N'Đại Học', N'Nam  ', CAST(N'1997-01-07' AS Date), N'Bắc Giang', N'NV        ', N'455354354645        ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV14      ', N'Nguyễn Vũ Anh Dương', N'Đại Học', N'Nam  ', CAST(N'1994-09-10' AS Date), N'Bình Định', N'NV        ', N'5435243532          ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV15      ', N'Trần Thanh Hòa', N'Đại Học', N'Nữ   ', CAST(N'1994-08-12' AS Date), N'THái Bình', N'MK        ', N'54235243636         ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV16      ', N'Nguyễn Chấn Huy', N'Đại Học', N'Nam  ', CAST(N'1993-06-07' AS Date), N'Nghệ An', N'MK        ', N'2353252345          ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV17      ', N'Nguyễn Lê Đình Huy', N'Đại Học', N'Nam  ', CAST(N'1994-09-07' AS Date), N'Hà Tĩnh', N'TC-KT     ', N'353454325           ', N'9877349500 ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV18      ', N'Mai Quốc Hùng', N'Đại Học', N'Nam  ', CAST(N'1994-09-07' AS Date), N'Thanh Hóa', N'TC-KT     ', N'5235255235          ', N'016765484  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV19      ', N'Nguyễn Thịnh Lâm Khang', N'Đại Học', N'Nam  ', CAST(N'1994-09-07' AS Date), N'Vĩnh Phúc', N'NV        ', N'55352235456         ', N'016765484  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV20      ', N'Bùi Nguyên Khánh', N'Đại Học', N'Nam  ', CAST(N'1994-07-07' AS Date), N'Phú Thọ', N'KT-KT     ', N'353425355435        ', N'016765484  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV21      ', N'Lâm Chí Kiệt', N'Đại Học', N'Nam  ', CAST(N'1994-07-07' AS Date), N'Hải Phòng', N'KT-KT     ', N'45324535345         ', N'016765484  ', N'Tày        ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV22      ', N'Trần Phạm Hoàng Long', N'Đại Học', N'Nam  ', CAST(N'1994-07-07' AS Date), N'Nam Định', N'NV        ', N'5325335235          ', N'016765484  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV23      ', N'Đoàn Điểm My', N'Đại Học', N'Nữ   ', CAST(N'1994-07-07' AS Date), N'Hà Nội', N'NV        ', N'532453245243        ', N'016765484  ', N'Kinh       ', N'không      ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [BangCap], [GioiTinh], [NgaySinh], [DiaChi], [MaPB], [CMTND], [SDT], [DanToc], [TonGiao]) VALUES (N'NV24      ', N'Nguyễn Hoàng 1', N'Đại Học', N'Nam  ', CAST(N'1994-07-07' AS Date), N'Yên Bái', N'NV        ', N'45645646466         ', N'016765484  ', N'Kinh       ', N'không      ')
GO
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV01      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV02      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV06      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV07      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV2       ', N'NV15      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV2       ', N'NV16      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV3       ', N'NV21      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV3       ', N'NV22      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV3       ', N'NV23      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV3       ', N'NV24      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV3       ', N'NV20      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV5       ', N'NV19      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV6       ', N'NV05      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV6       ', N'NV10      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV6       ', N'NV12      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV7       ', N'NV03      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV7       ', N'NV08      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV11      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV14      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV17      ')
INSERT [dbo].[NHANVIEN_CHUCVU] ([MaCV], [MaNV]) VALUES (N'CV4       ', N'NV18      ')
GO
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV01      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV02      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT7       ', N'NV03      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV04      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT3       ', N'NV05      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV06      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV07      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT7       ', N'NV08      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV09      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT3       ', N'NV10      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT3       ', N'NV11      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV12      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV13      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV14      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT5       ', N'NV15      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT5       ', N'NV16      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV17      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT2       ', N'NV18      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV19      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT3       ', N'NV20      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT3       ', N'NV21      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV22      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV23      ')
INSERT [dbo].[NHANVIEN_VITRI] ([MaVT], [MaNV]) VALUES (N'VT4       ', N'NV24      ')
GO
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'KT-KT     ', N'Kinh Tế - Kỹ Thuật', N'Quảng Nam', N'NV11      ', N'Đào Quang An')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'MK        ', N'MarKeting', N'Hòa Bình', N'NV03      ', N'Lê Trường Sơn')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'NV        ', N'Nội Vụ', N'Hà Nội', N'NV04      ', N'Đặng Tuấn Anh')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [DiaChi], [MaTP], [TenTP]) VALUES (N'TC-KT     ', N'Tài Chính - Kế Toán', N'Yên Bái', N'NV01      ', N'Nguyễn Hữu Chính')
GO
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT1       ', N'Thư Ký ')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT2       ', N'Kế Toán')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT3       ', N'Nhân viên Kỹ Thuật')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT4       ', N'Quản Lý Hồ Sơ - Thiết Bị')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT5       ', N'Marketting')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT6       ', N'Hành Chính - Nhân Sự')
INSERT [dbo].[VITRICONGVIEC] ([MaVT], [TenVT]) VALUES (N'VT7       ', N'Lễ Tân')
GO
ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HDLD]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[LUONG]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PHONGBAN] ([MaPB])
GO
ALTER TABLE [dbo].[NHANVIEN_CHUCVU]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN_CHUCVU]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN_VITRI]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NHANVIEN_VITRI]  WITH CHECK ADD FOREIGN KEY([MaVT])
REFERENCES [dbo].[VITRICONGVIEC] ([MaVT])
GO
ALTER TABLE [dbo].[PHONGBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBAN_NHANVIEN] FOREIGN KEY([MaTP])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHONGBAN] CHECK CONSTRAINT [FK_PHONGBAN_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[ThongTinnhanVien]    Script Date: 4/27/2021 10:53:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThongTinnhanVien] (@MaNV nvarchar(50))
as
begin
select n.MaNV, HoTen , GioiTinh, n.DiaChi, BangCap, CMTND, SDT, DanToc, TonGiao
from NHANVIEN n, PHONGBAN p, CHUCVU c, LUONG l, HDLD d, NHANVIEN_CHUCVU nv
where n.MaNV=l.MaNV and p.MaPB=n.MaPB and nv.MaCV=c.MaCV and n.MaNV=d.MaNV and n.MaNV=@MaNV
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu1] SET  READ_WRITE 
GO
