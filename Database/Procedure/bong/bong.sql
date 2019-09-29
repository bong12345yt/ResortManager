--Chuyển Khẩu...
if OBJECT_ID('SelectLoginUser','p') is not null
	drop proc SelectLoginUser
go
create proc SelectLoginUser
as
	select * from dbo.TAIKHOANDOAN
go