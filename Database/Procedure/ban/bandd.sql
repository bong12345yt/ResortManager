if OBJECT_ID ('usp_ThemThanhVien','p') is not null
	drop proc usp_ThemThanhVien
go
create proc usp_ThemThanhVien
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
	commit tran
go

exec usp_ThemThanhVien @CMND='123',@HoTen='Nguyen',@MaDoan='123'