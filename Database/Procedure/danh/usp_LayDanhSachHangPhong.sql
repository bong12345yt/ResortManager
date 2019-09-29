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

