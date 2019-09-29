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
exec usp_LayDanhSachTang

