if OBJECT_ID ('usp_LayDanhSachHangPhong','p') is not null
	drop proc usp_LayDanhSachHangPhong
go
create proc usp_LayDanhSachHangPhong
as
	begin tran
	select distinct HANG from LOAIPHONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách hạng phòng lỗi'
		return
	end
	commit tran
go

if OBJECT_ID ('usp_LayDanhSachLoaiPhong','p') is not null
	drop proc usp_LayDanhSachLoaiPhong
go
create proc usp_LayDanhSachLoaiPhong
as
	begin tran
	select distinct HINHTHUC from LOAIPHONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách hạng phòng lỗi'
		return
	end
	commit tran
go

if OBJECT_ID ('usp_LayDanhSachTang','p') is not null
	drop proc usp_LayDanhSachTang
go
create proc usp_LayDanhSachTang
as
	begin tran
	select distinct TANG from PHONG
	if(@@ERROR <> 0)
	begin
		Select N'Láy danh sách hạng phòng lỗi'
		return
	end
	commit tran
go

if OBJECT_ID ('usp_LayDanhSachPhongTheoDieuKien','p') is not null
	drop proc usp_LayDanhSachPhongTheoDieuKien
go
create proc usp_LayDanhSachPhongTheoDieuKien
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
go

if OBJECT_ID ('usp_CapNhatTinhTrangPhong','p') is not null
	drop proc usp_CapNhatTinhTrangPhong
go
create proc usp_CapNhatTinhTrangPhong
@maphong nchar(50),
@maDoan varchar(50)
as
	begin tran
	
	update PHONG
	set TINHTRANG = 'dang_dat_cho'
	where MAPHONG = @maphong
	
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
go


if OBJECT_ID ('usp_LayGiaPhong','p') is not null
	drop proc usp_LayGiaPhong
go
create proc usp_LayGiaPhong
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
go

if OBJECT_ID ('usp_LayCTGDtheoMaPhong','p') is not null
	drop proc usp_LayCTGDtheoMaPhong
go
create proc usp_LayCTGDtheoMaPhong
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
go

if OBJECT_ID ('usp_LayDachSachVatDung','p') is not null
	drop proc usp_LayDachSachVatDung
go
create proc usp_LayDachSachVatDung
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
go

if OBJECT_ID ('usp_ThemChiTietGiaoDich','p') is not null
	drop proc usp_ThemChiTietGiaoDich
go
create proc usp_ThemChiTietGiaoDich
@cmnd varchar(50),
@maDoan varchar(50),
@maPhong varchar(50)
as
	begin tran
	
	insert into CHITIETGIAODICH
	values(@cmnd, @maDoan,@maPhong)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm CTGD lỗi'
		rollback tran
		return
	end
	commit tran
go

if OBJECT_ID ('usp_LayMaCTGD','p') is not null
	drop proc usp_LayMaCTGD
go
create proc usp_LayMaCTGD
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
go

if OBJECT_ID ('usp_ThemPhieuTra','p') is not null
	drop proc usp_ThemPhieuTra
go
create proc usp_ThemPhieuTra
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
go

if OBJECT_ID ('usp_CapNhatPhieuTraTheoMaCTGD','p') is not null
	drop proc usp_CapNhatPhieuTraTheoMaCTGD
go
create proc usp_CapNhatPhieuTraTheoMaCTGD
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
go
exec usp_CapNhatPhieuTraTheoMaCTGD @maCTGD = 10, @tongTien = 22323

if OBJECT_ID ('usp_LayDSTVtheoMaDoan','p') is not null
	drop proc usp_LayDSTVtheoMaDoan
go
create proc usp_LayDSTVtheoMaDoan
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
go

if OBJECT_ID ('usp_LayPhieuTraTheoMaCTGD','p') is not null
	drop proc usp_LayPhieuTraTheoMaCTGD
go
create proc usp_LayPhieuTraTheoMaCTGD
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
go

if OBJECT_ID ('usp_ThemCTPT','p') is not null
	drop proc usp_ThemCTPT
go
create proc usp_ThemCTPT
@maCTGD int,
@maBT varchar(50),
@soluong int
as
	begin tran
	declare @maPT int
	select @maPT = MAPHIEU from PHIEUTRA where MACHITIETGD = @maCTGD
	insert into CHITIETPHIEUTRA
	values(@maBT, @soluong,@maPT)
	if(@@ERROR <> 0)
	begin
		Select N'Láy usp_ThemCTPT lỗi'
		rollback tran
		return
	end
	commit tran
go

if OBJECT_ID ('usp_LayCTPTtheoMaCTGD','p') is not null
	drop proc usp_LayCTPTtheoMaCTGD
go
create proc usp_LayCTPTtheoMaCTGD
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
go

exec usp_LayCTPTtheoMaCTGD @maCTGD = 10

--if OBJECT_ID ('usp_LayGiaTienTheoTen','p') is not null
--	drop proc usp_LayGiaTienTheoTen
--go
--create proc usp_LayGiaTienTheoTen
--@ten nchar(50)
--as
--	begin tran
	
--	select SOTIEN from BOITHUONG
--	where MOTA = @ten
	
--	if(@@ERROR <> 0)
--	begin
--		Select N'Láy tiền thất bại lỗi'
--		rollback tran
--		return
--	end
--	commit tran
--go

select ctgd.MACHITIET, tv.HOTEN, tv.CMND, lp.GIA, tv.MADOAN, p.MAPHONG from CHITIETGIAODICH ctgd, THANHVIEN tv, LOAIPHONG lp, PHONG p
	where ctgd.CMND = tv.CMND
	and ctgd.MADOAN = tv.MADOAN
	and ctgd.MAPHONG = p.MAPHONG
	and lp.MALOAI = p.MALOAI
	and ctgd.MAPHONG = 'P001'
exec usp_LayCTGDtheoMaPhong @maphong = 'P001'
