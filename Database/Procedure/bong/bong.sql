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
	select ct.MACHITIET ,ct.MADOAN, tv.HOTEN, ct.CMND, ct.MAPHONG, gd.NGAYBATDAU, gd.NGAYKETTHUC, lp.GIA, (DATEDIFF(DAY, gd.NGAYBATDAU, gd.NGAYKETTHUC) * lp.GIA) 'THANHTIEN' from dbo.CHITIETGIAODICH ct, dbo.GIAODICH gd, dbo.PHONG p, dbo.LOAIPHONG lp, dbo.THANHVIEN tv
	where ct.MADOAN = gd.MADOAN and ct.MAPHONG = p.MAPHONG and p.MALOAI = lp.MALOAI and ct.CMND = tv.CMND and ct.MADOAN = tv.MADOAN  and CAST(ct.MADOAN as varchar(30)) = @MADOAN
go

--Xóa Đạt chỗ...
if OBJECT_ID('DeleteDatCho','p') is not null
	drop proc DeleteDatCho
go
create proc DeleteDatCho
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
go
--exec SelectDatCho
--exec DeleteDatCho @MACHITIET = 5, @MADOAN = 'D002'