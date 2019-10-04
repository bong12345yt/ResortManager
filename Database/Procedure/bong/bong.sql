--Chuyển Khẩu...
if OBJECT_ID('SelectLoginUser','p') is not null
	drop proc SelectLoginUser
go
create proc SelectLoginUser
as
	select * from dbo.TAIKHOANDOAN
go

--Xem Danh Sách Đạt chỗ...
if OBJECT_ID('SelectDatCho','p') is not null
	drop proc SelectDatCho
go
create proc SelectDatCho
	@MADOAN nchar(30)
as
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	begin tran
	select ct.MACHITIET ,ct.MADOAN, tv.HOTEN, ct.CMND, ct.MAPHONG, gd.NGAYBATDAU, gd.NGAYKETTHUC, lp.GIA, (DATEDIFF(DAY, gd.NGAYBATDAU, gd.NGAYKETTHUC) * lp.GIA) 'THANHTIEN' from dbo.CHITIETGIAODICH ct, dbo.GIAODICH gd, dbo.PHONG p, dbo.LOAIPHONG lp, dbo.THANHVIEN tv
	where ct.MADOAN = gd.MADOAN and ct.MAPHONG = p.MAPHONG and p.MALOAI = lp.MALOAI and ct.CMND = tv.CMND and ct.MADOAN = tv.MADOAN  and CAST(ct.MADOAN as varchar(30)) = @MADOAN
	commit tran
go

--Xóa Đạt chỗ...
if OBJECT_ID('DeleteDatCho','p') is not null
	drop proc DeleteDatCho
go
create proc DeleteDatCho
	@MACHITIET int,
	@MADOAN nchar(30)
as	
    begin tran
	delete dbo.CHITIETGIAODICH
	where MACHITIET= @MACHITIET
	if(@@ERROR <> 0)
	begin
		Select N'Thêm thành viên lỗi'
		rollback tran
		return
	end
	
	declare @count int
	select @count = count(ct.MADOAN) from CHITIETGIAODICH ct
	where @MADOAN = ct.MADOAN
	print @count
	if @count <= 0
	begin
		delete dbo.GIAODICH
		where MADOAN = @MADOAN
		if(@@ERROR <> 0)
		begin
			Select N'Thêm thành viên lỗi'
			rollback tran
			return
		end
	end  
	commit tran
go

--Check Giao Dich...
if OBJECT_ID('CheckGiaoDich','p') is not null
	drop proc CheckGiaoDich
go
create proc CheckGiaoDich
as	
	
	select gd.MADOAN into #Madoantb from GIAODICH gd
	where gd.NGAYBATDAU +'02:00:00'< GetDate() and gd.NGAYKETTHUC > GetDate() and gd.TRANGTHAI = 'chua_thanh_cong'

	declare @MaDoan varchar(100)
	While (Select Count(*) From #Madoantb) > 0
	Begin
		Select Top 1 @MaDoan = MaDoan From #Madoantb
		begin tran
		delete CHITIETGIAODICH
		where MADOAN = @MaDoan
		if(@@ERROR <> 0)
		begin
			Select N'lỗi'
			rollback tran
			return
		end
		delete GIAODICH
		where MADOAN = @MaDoan
		if(@@ERROR <> 0)
		begin
			Select N'lỗi'
			rollback tran
			return
		end
		Delete #Madoantb Where @MaDoan = MaDoan
		if(@@ERROR <> 0)
		begin
			Select N'Thêm thành viên lỗi'
			rollback tran
			return
		end
		commit tran
	End

	drop table if exists #Madoantb

	
go

select gd.MADOAN  from GIAODICH gd
	where gd.NGAYBATDAU +'02:00:00'< GetDate() and gd.NGAYKETTHUC > GetDate() and gd.TRANGTHAI = 'chua_thanh_cong'

--exec CheckGiaoDich
--exec SelectDatCho
--exec DeleteDatCho @MACHITIET = 5, @MADOAN = 'D002'