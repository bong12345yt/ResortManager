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

If object_id('usp_PhatSinhMaDoan','p')is not null
	Drop proc usp_PhatSinhMaDoan
Go
Create proc usp_PhatSinhMaDoan
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

Declare @MaDoan nchar(30)
exec usp_PhatSinhMaDoan @MaDoan out
print @MaDoan