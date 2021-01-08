create proc Reg
	@Username nvarchar(200),
	@Password varchar(100)
as
insert into LoginDB(Username, Password)
values (@Username, @Password)


