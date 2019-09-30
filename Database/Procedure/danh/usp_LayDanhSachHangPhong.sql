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
@maphong nchar(50)
as
	begin tran
	
	update PHONG
	set TINHTRANG = 'dang_dat_cho'
	where MAPHONG = @maphong
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

