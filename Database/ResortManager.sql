USE [ResortManager]
GO
/****** Object:  Table [dbo].[THANHVIEN]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[THANHVIEN]
GO
/****** Object:  Table [dbo].[TAIKHOANDOAN]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[TAIKHOANDOAN]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[PHONG]
GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[PHIEUTRA]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[LOAIPHONG]
GO
/****** Object:  Table [dbo].[GIAODICH]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[GIAODICH]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRA]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[CHITIETPHIEUTRA]
GO
/****** Object:  Table [dbo].[CHITIETGIAODICH]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[CHITIETGIAODICH]
GO
/****** Object:  Table [dbo].[BOITHUONG]    Script Date: 05/10/2019 12:28:45 AM ******/
DROP TABLE [dbo].[BOITHUONG]
GO
/****** Object:  Table [dbo].[BOITHUONG]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[CHITIETGIAODICH]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[CHITIETPHIEUTRA]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[GIAODICH]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[PHONG]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[TAIKHOANDOAN]    Script Date: 05/10/2019 12:28:45 AM ******/
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
/****** Object:  Table [dbo].[THANHVIEN]    Script Date: 05/10/2019 12:28:45 AM ******/
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
