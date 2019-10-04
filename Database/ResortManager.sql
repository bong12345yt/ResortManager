USE [ResortManager]
GO
/****** Object:  StoredProcedure [dbo].[usp_XoaThanhVienTheoMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_XoaThanhVienTheoMaDoan]
GO
/****** Object:  StoredProcedure [dbo].[usp_XoaGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_XoaGiaoDich]
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemThanhVien]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ThemThanhVien]
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemTaiKhoan]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ThemTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemPhieuTra]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ThemPhieuTra]
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ThemGiaoDich]
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemChiTietGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ThemChiTietGiaoDich]
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemCTPT]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ThemCTPT]
GO
/****** Object:  StoredProcedure [dbo].[usp_PhatSinhMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_PhatSinhMaDoan]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayPhieuTraTheoMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayPhieuTraTheoMaCTGD]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayMaCTGD]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayGiaPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayGiaPhong]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDSTVtheoMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayDSTVtheoMaDoan]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachTang]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayDanhSachTang]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachPhongTheoDieuKien]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayDanhSachPhongTheoDieuKien]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachLoaiPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayDanhSachLoaiPhong]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachHangPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayDanhSachHangPhong]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDachSachVatDung]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayDachSachVatDung]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayCTPTtheoMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayCTPTtheoMaCTGD]
GO
/****** Object:  StoredProcedure [dbo].[usp_LayCTGDtheoMaPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_LayCTGDtheoMaPhong]
GO
/****** Object:  StoredProcedure [dbo].[usp_ErrThemChiTietGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ErrThemChiTietGiaoDich]
GO
/****** Object:  StoredProcedure [dbo].[usp_ErrLayDanhSachPhongTheoDieuKien]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_ErrLayDanhSachPhongTheoDieuKien]
GO
/****** Object:  StoredProcedure [dbo].[usp_Err10SCapNhatTinhTrangPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_Err10SCapNhatTinhTrangPhong]
GO
/****** Object:  StoredProcedure [dbo].[usp_DanhSachNhanPhongTheoMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_DanhSachNhanPhongTheoMaDoan]
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatTinhTrangPhongDangRanh]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_CapNhatTinhTrangPhongDangRanh]
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatTinhTrangPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_CapNhatTinhTrangPhong]
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatTinhTrangCoKhach]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_CapNhatTinhTrangCoKhach]
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatPhieuTraTheoMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[usp_CapNhatPhieuTraTheoMaCTGD]
GO
/****** Object:  StoredProcedure [dbo].[SelectLoginUser]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[SelectLoginUser]
GO
/****** Object:  StoredProcedure [dbo].[SelectDatCho]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[SelectDatCho]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDatCho]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP PROCEDURE [dbo].[DeleteDatCho]
GO
/****** Object:  Table [dbo].[THANHVIEN]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[THANHVIEN]
GO
/****** Object:  Table [dbo].[TAIKHOANDOAN]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[TAIKHOANDOAN]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[PHONG]
GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[PHIEUTRA]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[LOAIPHONG]
GO
/****** Object:  Table [dbo].[GIAODICH]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[GIAODICH]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRA]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[CHITIETPHIEUTRA]
GO
/****** Object:  Table [dbo].[CHITIETGIAODICH]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[CHITIETGIAODICH]
GO
/****** Object:  Table [dbo].[BOITHUONG]    Script Date: 05/10/2019 12:19:06 AM ******/
DROP TABLE [dbo].[BOITHUONG]
GO
/****** Object:  Table [dbo].[BOITHUONG]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOITHUONG](
	[MABOITHUONG] [nchar](50) NOT NULL,
	[MOTA] [nvarchar](100) NULL,
	[SOTIEN] [int] NULL,
 CONSTRAINT [PK_BOITHUONG] PRIMARY KEY CLUSTERED 
(
	[MABOITHUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETGIAODICH]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETGIAODICH](
	[MACHITIET] [int] IDENTITY(1,1) NOT NULL,
	[CMND] [nchar](50) NULL,
	[MADOAN] [nchar](30) NULL,
	[MAPHONG] [nchar](50) NULL,
 CONSTRAINT [PK_CHITIETGIAODICH] PRIMARY KEY CLUSTERED 
(
	[MACHITIET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRA]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTRA](
	[MACHITIET] [int] NOT NULL,
	[MABOITHUONG] [nchar](50) NULL,
	[SOLUONG] [int] NULL,
	[MAPHIEUTRA] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUTRA2] PRIMARY KEY CLUSTERED 
(
	[MACHITIET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAODICH]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAODICH](
	[MADOAN] [nchar](30) NOT NULL,
	[SONGUOI] [int] NULL,
	[SOPHONG] [int] NULL,
	[NGAYBATDAU] [datetime] NULL,
	[NGAYKETTHUC] [datetime] NULL,
	[TONGTIEN] [int] NULL,
	[CMND] [nchar](50) NULL,
	[TRANGTHAI] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIAODICH] PRIMARY KEY CLUSTERED 
(
	[MADOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MALOAI] [nchar](50) NOT NULL,
	[HINHTHUC] [nvarchar](50) NULL,
	[GIA] [int] NULL,
	[HANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[MAPHIEU] [int] IDENTITY(1,1) NOT NULL,
	[NGAYTHANHTOAN] [datetime] NULL,
	[TONGTIEN] [int] NULL,
	[MACHITIETGD] [nchar](50) NULL,
 CONSTRAINT [PK_PHIEUTRA_1] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MAPHONG] [nchar](50) NOT NULL,
	[TANG] [int] NULL,
	[TINHTRANG] [nvarchar](50) NULL,
	[MALOAI] [nchar](50) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOANDOAN]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOANDOAN](
	[TENTAIKHOAN] [nchar](50) NOT NULL,
	[MATKHAU] [nchar](50) NULL,
	[MADOAN] [nchar](30) NULL,
 CONSTRAINT [PK_TAIKHOANDOAN] PRIMARY KEY CLUSTERED 
(
	[TENTAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHVIEN]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHVIEN](
	[CMND] [nchar](50) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[MADOAN] [nchar](30) NOT NULL,
 CONSTRAINT [PK_THANHVIEN_1] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC,
	[MADOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT001                                             ', N'bóng đèn', 50000)
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT002                                             ', N'ghế ngồi', 150000)
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT003                                             ', N'giường', 5000000)
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT004                                             ', N'ghế', 300000)
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT005                                             ', N'ga giường', 50000)
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT006                                             ', N'cửa vệ sinh', 750000)
GO
INSERT [dbo].[BOITHUONG] ([MABOITHUONG], [MOTA], [SOTIEN]) VALUES (N'BT007                                             ', N'cửa chính', 1000000)
GO
SET IDENTITY_INSERT [dbo].[CHITIETGIAODICH] ON 
GO
INSERT [dbo].[CHITIETGIAODICH] ([MACHITIET], [CMND], [MADOAN], [MAPHONG]) VALUES (1, N'123456701                                         ', N'D001                          ', N'P001                                              ')
GO
INSERT [dbo].[CHITIETGIAODICH] ([MACHITIET], [CMND], [MADOAN], [MAPHONG]) VALUES (2, N'123456702                                         ', N'D001                          ', N'P001                                              ')
GO
INSERT [dbo].[CHITIETGIAODICH] ([MACHITIET], [CMND], [MADOAN], [MAPHONG]) VALUES (3, N'123456703                                         ', N'D001                          ', N'P002                                              ')
GO
INSERT [dbo].[CHITIETGIAODICH] ([MACHITIET], [CMND], [MADOAN], [MAPHONG]) VALUES (4, N'123456704                                         ', N'D001                          ', N'P002                                              ')
GO
INSERT [dbo].[CHITIETGIAODICH] ([MACHITIET], [CMND], [MADOAN], [MAPHONG]) VALUES (5, N'123456707                                         ', N'D003                          ', N'P001                                              ')
GO
INSERT [dbo].[CHITIETGIAODICH] ([MACHITIET], [CMND], [MADOAN], [MAPHONG]) VALUES (6, N'123456708                                         ', N'D003                          ', N'P004                                              ')
GO
SET IDENTITY_INSERT [dbo].[CHITIETGIAODICH] OFF
GO
INSERT [dbo].[GIAODICH] ([MADOAN], [SONGUOI], [SOPHONG], [NGAYBATDAU], [NGAYKETTHUC], [TONGTIEN], [CMND], [TRANGTHAI]) VALUES (N'123456                        ', 0, 0, CAST(N'2019-10-10T10:00:00.000' AS DateTime), CAST(N'2019-10-11T11:00:00.000' AS DateTime), 0, N'123                                               ', N'xx')
GO
INSERT [dbo].[GIAODICH] ([MADOAN], [SONGUOI], [SOPHONG], [NGAYBATDAU], [NGAYKETTHUC], [TONGTIEN], [CMND], [TRANGTHAI]) VALUES (N'D001                          ', 4, 2, CAST(N'2019-10-10T10:00:00.000' AS DateTime), CAST(N'2019-10-25T10:00:00.000' AS DateTime), 10500000, N'123456701                                         ', N'thanh_cong')
GO
INSERT [dbo].[GIAODICH] ([MADOAN], [SONGUOI], [SOPHONG], [NGAYBATDAU], [NGAYKETTHUC], [TONGTIEN], [CMND], [TRANGTHAI]) VALUES (N'D002                          ', 2, 0, CAST(N'2019-10-20T10:00:00.000' AS DateTime), CAST(N'2019-10-29T10:00:00.000' AS DateTime), 0, N'123456705                                         ', N'chua_thanh_cong')
GO
INSERT [dbo].[GIAODICH] ([MADOAN], [SONGUOI], [SOPHONG], [NGAYBATDAU], [NGAYKETTHUC], [TONGTIEN], [CMND], [TRANGTHAI]) VALUES (N'D003                          ', 2, 2, CAST(N'2019-09-02T05:59:00.000' AS DateTime), CAST(N'2019-09-10T17:05:00.000' AS DateTime), 8100000, N'123456707                                         ', N'thanh_cong')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L001                                              ', N'1_giuong_don', 300000, N'thuong')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L002                                              ', N'1_giuong_doi', 400000, N'thuong')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L003                                              ', N'2_giuong_don', 500000, N'thuong')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L004                                              ', N'2_giuong_doi', 600000, N'thuong')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L005                                              ', N'1_giuong_don', 700000, N'trung_binh')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L006                                              ', N'1_giuong_doi', 800000, N'trung_binh')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L007                                              ', N'2_giuong_don', 900000, N'trung_binh')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L008                                              ', N'2_giuong_doi', 1000000, N'trung_binh')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L009                                              ', N'1_giuong_don', 1100000, N'sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L010                                              ', N'1_giuong_doi', 1200000, N'sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L011                                              ', N'2_giuong_don', 1300000, N'sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L012                                              ', N'2_giuong_doi', 1400000, N'sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L013                                              ', N'1_giuong_don', 1500000, N'rat_sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L014                                              ', N'1_giuong_doi', 1600000, N'rat_sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L015                                              ', N'2_giuong_don', 1700000, N'rat_sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L016                                              ', N'2_giuong_doi', 1800000, N'rat_sang')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L017                                              ', N'1_giuong_don', 1900000, N'vip')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L018                                              ', N'1_giuong_doi', 2000000, N'vip')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L019                                              ', N'2_giuong_don', 2100000, N'vip')
GO
INSERT [dbo].[LOAIPHONG] ([MALOAI], [HINHTHUC], [GIA], [HANG]) VALUES (N'L020                                              ', N'2_giuong_doi', 2200000, N'vip')
GO
SET IDENTITY_INSERT [dbo].[PHIEUTRA] ON 
GO
INSERT [dbo].[PHIEUTRA] ([MAPHIEU], [NGAYTHANHTOAN], [TONGTIEN], [MACHITIETGD]) VALUES (1, CAST(N'2019-09-10T17:00:00.000' AS DateTime), 2700000, N'5                                                 ')
GO
INSERT [dbo].[PHIEUTRA] ([MAPHIEU], [NGAYTHANHTOAN], [TONGTIEN], [MACHITIETGD]) VALUES (2, CAST(N'2019-09-10T17:00:00.000' AS DateTime), 5400000, N'6                                                 ')
GO
SET IDENTITY_INSERT [dbo].[PHIEUTRA] OFF
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P001                                              ', 1, N'dang_dat_cho', N'L001                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P002                                              ', 1, N'dang_dat_cho', N'L002                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P003                                              ', 1, N'ranh', N'L003                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P004                                              ', 1, N'ranh', N'L004                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P005                                              ', 2, N'ranh', N'L005                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P006                                              ', 2, N'ranh', N'L006                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P007                                              ', 2, N'ranh', N'L007                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P008                                              ', 2, N'ranh', N'L008                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P009                                              ', 3, N'ranh', N'L009                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P010                                              ', 3, N'ranh', N'L010                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P011                                              ', 3, N'ranh', N'L011                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P012                                              ', 3, N'ranh', N'L012                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P013                                              ', 4, N'ranh', N'L013                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P014                                              ', 4, N'ranh', N'L014                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P015                                              ', 4, N'ranh', N'L015                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P016                                              ', 4, N'ranh', N'L016                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P017                                              ', 5, N'ranh', N'L017                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P018                                              ', 5, N'ranh', N'L018                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P019                                              ', 5, N'ranh', N'L019                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P020                                              ', 5, N'ranh', N'L020                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P021                                              ', 1, N'ranh', N'L001                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P022                                              ', 2, N'ranh', N'L002                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P023                                              ', 3, N'ranh', N'L003                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P024                                              ', 4, N'ranh', N'L004                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P025                                              ', 5, N'ranh', N'L005                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P026                                              ', 6, N'ranh', N'L006                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P027                                              ', 7, N'ranh', N'L007                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P028                                              ', 8, N'ranh', N'L008                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P029                                              ', 9, N'ranh', N'L009                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P030                                              ', 1, N'ranh', N'L001                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P031                                              ', 2, N'ranh', N'L002                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P032                                              ', 3, N'ranh', N'L003                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P033                                              ', 4, N'ranh', N'L004                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P034                                              ', 5, N'ranh', N'L005                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P035                                              ', 6, N'ranh', N'L006                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P036                                              ', 7, N'ranh', N'L007                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P037                                              ', 8, N'ranh', N'L008                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P038                                              ', 9, N'ranh', N'L009                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P039                                              ', 1, N'ranh', N'L001                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P040                                              ', 2, N'ranh', N'L002                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P041                                              ', 3, N'ranh', N'L003                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P042                                              ', 4, N'ranh', N'L004                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P043                                              ', 5, N'ranh', N'L005                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P044                                              ', 6, N'ranh', N'L006                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P045                                              ', 7, N'ranh', N'L007                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P046                                              ', 8, N'ranh', N'L008                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P047                                              ', 9, N'ranh', N'L009                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P048                                              ', 1, N'ranh', N'L001                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P049                                              ', 2, N'ranh', N'L002                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P050                                              ', 3, N'ranh', N'L003                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P051                                              ', 4, N'ranh', N'L004                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P052                                              ', 5, N'ranh', N'L005                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P053                                              ', 6, N'ranh', N'L006                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P054                                              ', 7, N'ranh', N'L007                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P055                                              ', 8, N'ranh', N'L008                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P056                                              ', 9, N'ranh', N'L009                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P057                                              ', 1, N'ranh', N'L001                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P058                                              ', 2, N'ranh', N'L002                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P059                                              ', 3, N'ranh', N'L003                                              ')
GO
INSERT [dbo].[PHONG] ([MAPHONG], [TANG], [TINHTRANG], [MALOAI]) VALUES (N'P060                                              ', 4, N'ranh', N'L004                                              ')
GO
INSERT [dbo].[TAIKHOANDOAN] ([TENTAIKHOAN], [MATKHAU], [MADOAN]) VALUES (N'ADMIN                                             ', N'123456                                            ', N'ADMIN                         ')
GO
INSERT [dbo].[TAIKHOANDOAN] ([TENTAIKHOAN], [MATKHAU], [MADOAN]) VALUES (N'D001                                              ', N'123456                                            ', N'D001                          ')
GO
INSERT [dbo].[TAIKHOANDOAN] ([TENTAIKHOAN], [MATKHAU], [MADOAN]) VALUES (N'D002                                              ', N'123456                                            ', N'D002                          ')
GO
INSERT [dbo].[TAIKHOANDOAN] ([TENTAIKHOAN], [MATKHAU], [MADOAN]) VALUES (N'D003                                              ', N'123456                                            ', N'D003                          ')
GO
INSERT [dbo].[TAIKHOANDOAN] ([TENTAIKHOAN], [MATKHAU], [MADOAN]) VALUES (N'D004                                              ', N'123456                                            ', N'D004                          ')
GO
INSERT [dbo].[TAIKHOANDOAN] ([TENTAIKHOAN], [MATKHAU], [MADOAN]) VALUES (N'D005                                              ', N'123456                                            ', N'D005                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123                                               ', N'Nguyen', N'123                           ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456701                                         ', N'Nguyen Van A', N'D001                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456702                                         ', N'Hoang Huy B', N'D001                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456703                                         ', N'Lo Thi L', N'D001                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456704                                         ', N'Long Van Long', N'D001                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456705                                         ', N'Le Danh Danh', N'D002                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456706                                         ', N'Le Bong Bong', N'D002                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456707                                         ', N'Nguyen Huy Dat', N'D003                          ')
GO
INSERT [dbo].[THANHVIEN] ([CMND], [HOTEN], [MADOAN]) VALUES (N'123456708                                         ', N'Le Ban Ban', N'D003                          ')
GO
/****** Object:  StoredProcedure [dbo].[DeleteDatCho]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDatCho]
	@MACHITIET int,
	@MADOAN nchar(30)
as	
	delete dbo.CHITIETGIAODICH
	where MACHITIET= @MACHITIET
	
	declare @count int
	select @count = count(ct.MADOAN) from CHITIETGIAODICH ct
	where @MADOAN = ct.MADOAN
	print @count
	if @count <= 0
	begin
		delete dbo.GIAODICH
		where MADOAN = @MADOAN
	end  
GO
/****** Object:  StoredProcedure [dbo].[SelectDatCho]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectDatCho]
	@MADOAN nchar(30)
as
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	begin tran
	select ct.MACHITIET ,ct.MADOAN, tv.HOTEN, ct.CMND, ct.MAPHONG, gd.NGAYBATDAU, gd.NGAYKETTHUC, lp.GIA, (DATEDIFF(DAY, gd.NGAYBATDAU, gd.NGAYKETTHUC) * lp.GIA) 'THANHTIEN' from dbo.CHITIETGIAODICH ct, dbo.GIAODICH gd, dbo.PHONG p, dbo.LOAIPHONG lp, dbo.THANHVIEN tv
	where ct.MADOAN = gd.MADOAN and ct.MAPHONG = p.MAPHONG and p.MALOAI = lp.MALOAI and ct.CMND = tv.CMND and ct.MADOAN = tv.MADOAN  and CAST(ct.MADOAN as varchar(30)) = @MADOAN
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[SelectLoginUser]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectLoginUser]
as
	select * from dbo.TAIKHOANDOAN
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatPhieuTraTheoMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_CapNhatPhieuTraTheoMaCTGD]
@maCTGD int,
@tongTien int
as
	begin tran
	
	update PHIEUTRA
	set NGAYTHANHTOAN = GETDATE(), TONGTIEN = @tongTien
	WHERE MACHITIETGD = @maCTGD
	if(@@ERROR <> 0)
	begin
		Select N'Thêm usp_CapNhatPhieuTraTheoMaCTGD lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatTinhTrangCoKhach]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_CapNhatTinhTrangCoKhach]
@MaPhong nchar(50)
as
	begin tran
	update PHONG
	set TINHTRANG = 'co_khach'
	where MAPHONG = @MaPhong
	if(@@ERROR <> 0)
	begin
		Select N'Update trang thai phong loi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatTinhTrangPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_CapNhatTinhTrangPhong]
@maphong nchar(50),
@maDoan varchar(50),
@kq int out
as
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	begin tran 
	begin try
		SELECT * FROM PHONG WHERE MAPHONG = @maphong
		set @kq = 0
		WAITFOR DELAY '00:00:01'
		update PHONG
		set TINHTRANG = 'dang_dat_cho'
		where MAPHONG = @maphong
		if(@@ERROR <> 0)
		begin
			set @kq = -1
			Select N'cập nhật tình trạng lỗi'
			rollback tran
			return
		end
		
		update GIAODICH
		set SOPHONG = SOPHONG + 1
		from GIAODICH where MADOAN = @maDoan
		if(@@ERROR <> 0)
		begin
			Select N'cập nhật tình trạng lỗi'
			rollback tran
			return
		end
		commit tran
	end try
	
	begin catch
		if ERROR_NUMBER() <> 0
		begin
			set @kq = -1
			
		end
	end catch
GO
/****** Object:  StoredProcedure [dbo].[usp_CapNhatTinhTrangPhongDangRanh]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_CapNhatTinhTrangPhongDangRanh]
@maphong nchar(50)
as
	begin tran
	
	update PHONG
	set TINHTRANG = 'ranh'
	where MAPHONG = @maphong
	
	if(@@ERROR <> 0)
	begin
		Select N' usp_CapNhatTinhTrangPhongDangRanh lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_DanhSachNhanPhongTheoMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[usp_DanhSachNhanPhongTheoMaDoan]
@MADOAN nchar(30)
as
	begin tran
		select p.MAPHONG, p.TINHTRANG, lp.HINHTHUC, lp.HANG, ctgd.CMND
		from CHITIETGIAODICH as ctgd, PHONG as p, LOAIPHONG as lp
		where p.MAPHONG = ctgd.MAPHONG
			and p.MALOAI = lp.MALOAI
			and ctgd.MADOAN = @MADOAN
			and p.TINHTRANG = 'dang_dat_cho'

		if(@@ERROR <> 0)
		begin
			Select N'Loi lay danh sach nhan phong'
			rollback tran
			return
		end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_Err10SCapNhatTinhTrangPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Err10SCapNhatTinhTrangPhong]
@maphong nchar(50),
@maDoan varchar(50),
@kq int out
as
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
	begin tran 
	begin try
		SELECT * FROM PHONG WHERE MAPHONG = @maphong
		set @kq = 0
		waitfor delay '00:00:20'
		
		update PHONG
		set TINHTRANG = 'dang_dat_cho'
		where MAPHONG = @maphong
		if(@@ERROR <> 0)
		begin
			set @kq = -1
			Select N'usp_Err10SCapNhatTinhTrangPhong lỗi'
			rollback tran
			return
		end
		
		update GIAODICH
		set SOPHONG = SOPHONG + 1
		from GIAODICH where MADOAN = @maDoan
		if(@@ERROR <> 0)
		begin
			Select N'usp_Err10SCapNhatTinhTrangPhong lỗi'
			rollback tran
			return
		end
		commit tran
	end try
	
	begin catch
		if ERROR_NUMBER() <> 0
		begin
			set @kq = -1
		end
	end catch
GO
/****** Object:  StoredProcedure [dbo].[usp_ErrLayDanhSachPhongTheoDieuKien]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ErrLayDanhSachPhongTheoDieuKien]
@hang nchar(50),
@hinhthuc nvarchar(50),
@tang int
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	begin tran
	
	select p.*, lp.GIA from PHONG p, LOAIPHONG lp
	where p.MALOAI = lp.MALOAI
	and HANG = @hang
	and HINHTHUC = @hinhthuc
	and TANG = @tang
	and p.TINHTRANG = 'ranh'
	
	waitfor delay '00:00:20'
	
	select p.*, lp.GIA from PHONG p, LOAIPHONG lp
	where p.MALOAI = lp.MALOAI
	and HANG = @hang
	and HINHTHUC = @hinhthuc
	and TANG = @tang
	and p.TINHTRANG = 'ranh'
	if(@@ERROR <> 0)
	begin
		Select N'Thêm thành viên lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_ErrThemChiTietGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ErrThemChiTietGiaoDich]
@cmnd varchar(50),
@maDoan varchar(50),
@maPhong varchar(50)
as
--SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	begin tran
	
	insert into CHITIETGIAODICH
	values(@cmnd, @maDoan,@maPhong)
	WAITFOR DELAY '00:00:20';
	if (LEN(@cmnd) < 10)
	begin
		rollback tran
	end
	if(@@ERROR <> 0)
	begin
		Select N'Thêm usp_ErrThemChiTietGiaoDich lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayCTGDtheoMaPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayCTGDtheoMaPhong]
@maphong varchar(50)
as
	begin tran
	
	select ctgd.MACHITIET, tv.HOTEN, tv.CMND, lp.GIA, tv.MADOAN, p.MAPHONG from CHITIETGIAODICH ctgd, THANHVIEN tv, LOAIPHONG lp, PHONG p
	where ctgd.CMND = tv.CMND
	and ctgd.MADOAN = tv.MADOAN
	and ctgd.MAPHONG = p.MAPHONG
	and lp.MALOAI = p.MALOAI
	and ctgd.MAPHONG like '%' + @maphong + '%'
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách CTGD lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayCTPTtheoMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayCTPTtheoMaCTGD]
@maCTGD int
as
	begin tran
	declare @maPT int
	select @maPT = MAPHIEU from PHIEUTRA where MACHITIETGD = @maCTGD
	select * from CHITIETPHIEUTRA
	where MAPHIEUTRA = @maPT
	if(@@ERROR <> 0)
	begin
		Select N'Láy usp_LayCTPTtheoMaGD lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDachSachVatDung]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayDachSachVatDung]
as
	begin tran
	
	select * from BOITHUONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách vật dụng lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachHangPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayDanhSachHangPhong]
as
	begin tran
	select distinct HANG from LOAIPHONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách hạng phòng lỗi'
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachLoaiPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayDanhSachLoaiPhong]
as
	begin tran
	select distinct HINHTHUC from LOAIPHONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách hạng phòng lỗi'
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachPhongTheoDieuKien]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayDanhSachPhongTheoDieuKien]
@hang nchar(50),
@hinhthuc nvarchar(50),
@tang int
as
	begin tran
	
	select p.*, lp.GIA from PHONG p, LOAIPHONG lp
	where p.MALOAI = lp.MALOAI
	and HANG = @hang
	and HINHTHUC = @hinhthuc
	and TANG = @tang
	and p.TINHTRANG = 'ranh'
	if(@@ERROR <> 0)
	begin
		Select N'Thêm thành viên lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDanhSachTang]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayDanhSachTang]
as
	begin tran
	select distinct TANG from PHONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách hạng phòng lỗi'
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayDSTVtheoMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayDSTVtheoMaDoan]
@maDoan varchar(50)
as
	begin tran
	
	select * from THANHVIEN
	where MADOAN = @maDoan
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách thành viên lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayGiaPhong]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayGiaPhong]
@hang nchar(50),
@hinhthuc nchar(50)
as
	begin tran
	
	select GIA from LOAIPHONG
	where HANG = @hang
	and HINHTHUC = @hinhthuc
	if(@@ERROR <> 0)
	begin
		Select N'Láy giá lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayMaCTGD]
@cmnd varchar(50)
as
	begin tran
	
	select MACHITIET from CHITIETGIAODICH
	where CMND = @cmnd
	if(@@ERROR <> 0)
	begin
		Select N'Láy mã CTGD lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_LayPhieuTraTheoMaCTGD]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_LayPhieuTraTheoMaCTGD]
@maGD int
as
	begin tran
	
	select MAPHIEU from PHIEUTRA
	where MACHITIETGD = @maGD
	if(@@ERROR <> 0)
	begin
		Select N'Láy usp_LayPhieuTraTheoMaCTGD lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_PhatSinhMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_PhatSinhMaDoan]
	@MaDoan nchar(30) out
AS
	Declare @i int = 1
	Set @MaDoan = 'D001'
	While EXISTS (Select *
				  From GIAODICH gd
				  Where gd.MADOAN = @MaDoan)
	Begin
		Set @MaDoan = 'D' + REPLICATE('0',3-LEN(LTrim(str(@i)))) + LTRIM(STR(@i));
		Set @i = @i + 1 
	End
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemCTPT]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemCTPT]
@maCTGD int,
@maBT varchar(50),
@soluong int
as
	begin tran
	declare @maPT int
	select @maPT = MAPHIEU from PHIEUTRA where MACHITIETGD = @maCTGD
	insert into CHITIETPHIEUTRA(MABOITHUONG, SOLUONG, MAPHIEUTRA)
	values(@maBT, @soluong,@maPT)
	if(@@ERROR <> 0)
	begin
		Select N'Láy usp_ThemCTPT lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemChiTietGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemChiTietGiaoDich]
@cmnd varchar(50),
@maDoan varchar(50),
@maPhong varchar(50)
as
	begin tran
	
	insert into CHITIETGIAODICH
	values(@cmnd, @maDoan,@maPhong)
	--WAITFOR DELAY '00:00:20';
	--if (LEN(@cmnd) < 10)
	--begin
	--	rollback tran
	--end
	if(@@ERROR <> 0)
	begin
		Select N'Thêm CTGD lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemGiaoDich]
@MaDoan nchar(30),
@SoNguoi int,
@SoPhong int,
@NgayBatDau datetime,
@NgayKetThuc datetime,
@TongTien int,
@CMND nchar(50),
@TrangThai nvarchar(50),
@KetQua int out
as
	if(CAST(@NgayBatDau AS DATE) >= CAST(@NgayKetThuc AS DATE))
	begin
		select N'Ngày bắt đầu phải nhỏ hơn ngày kết thúc'
		set @KetQua = -1
		return
	end
	begin tran
	insert into GIAODICH
	values(@MaDoan,@SoNguoi,@SoPhong,@NgayBatDau,@NgayKetThuc,@TongTien,@CMND,@TrangThai)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm giao dịch lỗi'
		set @KetQua = -2
		rollback tran
		return
	end
	insert into TAIKHOANDOAN
	values(@MaDoan,'123456',@MaDoan)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm tài khoản lỗi'
		set @KetQua = -3
		rollback tran
		return
	end
	set @KetQua = 0
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemPhieuTra]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemPhieuTra]
@maCTGD int
as
	begin tran
	
	insert into PHIEUTRA
	values('', '', @maCTGD)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm PHIEUTRA lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemTaiKhoan]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemTaiKhoan]
@TenTK nchar(50),
@MatKhau nchar(50),
@MaDoan nchar(30)
as
	begin tran
	insert into TAIKHOANDOAN
	values(@TenTK,@MatKhau,@MaDoan)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm tài khoản lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemThanhVien]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_ThemThanhVien]
@CMND nchar(50),
@HoTen nvarchar(50),
@MaDoan nchar(30)
as
	begin tran
	insert into THANHVIEN
	values(@CMND,@HoTen,@MaDoan)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm thành viên lỗi'
		rollback tran
		return
	end
	update GIAODICH
	set SONGUOI=SONGUOI+1
	where MADOAN=@MaDoan
	if(@@ERROR <> 0)
	begin
		Select N'Cập nhập số người trong giao dịch lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_XoaGiaoDich]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_XoaGiaoDich]
@MaDoan nchar(30)
as
	begin tran
	delete GIAODICH
	where MADOAN = @MaDoan
	if(@@ERROR <> 0)
	begin
		Select N'Xóa giao dịch lỗi'
		rollback tran
		return
	end
	commit tran
GO
/****** Object:  StoredProcedure [dbo].[usp_XoaThanhVienTheoMaDoan]    Script Date: 05/10/2019 12:19:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_XoaThanhVienTheoMaDoan]
@MaDoan nchar(30)
as
	begin tran
	delete THANHVIEN
	where MADOAN = @MaDoan
	if(@@ERROR <> 0)
	begin
		Select N'Xóa thành viên theo mã đoàn lỗi'
		rollback tran
		return
	end
	commit tran
GO
