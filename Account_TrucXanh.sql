-- Họ tên: Phạm Đình Luân
-- MSSV: 1560320

create database ACCOUNT_TRUCXANH
go
use ACCOUNT_TRUCXANH
go

create table Account(
	username varchar(10) primary key,
	password varchar(10),
	score int
)

go
-- nếu tồn tại username: return 0, tồn tại username và password: return 1
-- ngược lại return -1
create proc sp_KiemTraTonTai
	@user varchar(10),
	@pass varchar(10)
as
begin
	if exists (select * from Account where username = @user and password = @pass)
		return 1
	if exists (select * from Account where username = @user)
		return 0
	return -1
end


go
create proc sp_GetScore
	@user varchar(10)
as
begin
	declare @kq int
	select @kq = score from Account where username = @user
	return @kq
end

------------------
go
insert into Account values('admin', 'admin', 1000);