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

if OBJECT_ID ('usp_ThemGiaoDich','p') is not null
	drop proc usp_ThemGiaoDich
go
create proc usp_ThemGiaoDich
@MaDoan nchar(30),
@SoNguoi int,
@SoPhong int,
@NgayBatDau datetime,
@NgayKetThuc datetime,
@TongTien int,
@CMND nchar(50),
@TrangThai nvarchar(50)
as
	begin tran
	insert into GIAODICH
	values(@MaDoan,@SoNguoi,@SoPhong,@NgayBatDau,@NgayKetThuc,@TongTien,@CMND,@TrangThai)
	if(@@ERROR <> 0)
	begin
		Select N'Thêm giao dịch lỗi'
		rollback tran
		return
	end
	commit tran
go

if OBJECT_ID ('usp_XoaThanhVienTheoMaDoan','p') is not null
	drop proc usp_XoaThanhVienTheoMaDoan
go
create proc usp_XoaThanhVienTheoMaDoan
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
go

if OBJECT_ID ('usp_XoaGiaoDich','p') is not null
	drop proc usp_XoaGiaoDich
go
create proc usp_XoaGiaoDich
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
go