/*
Created		1/3/2021
Modified		1/3/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/

go
create database notebook
go
use notebook
go

go
Create table [NoteDB]
(
	[No] Integer  NOT NULL identity(1, 1),
	[Title] Nvarchar(200) NOT NULL,
	[Date] Smalldatetime NULL,
	[Desciption] Nvarchar(4000) NULL,
Primary Key ([Title])
) 
go

go
Create table [LoginDB]
(
	[No] Integer NOT NULL identity(1, 1) ,
	[Username] Nvarchar(200) NOT NULL,
	[Password] Varchar(100) NULL,
Primary Key ([Username])
) 
go

go
Create table [Note]
(
	[No] Integer  NOT NULL,
	[Title] Nvarchar(200) NOT NULL,
	[Username] Nvarchar(200) NOT NULL,
Primary Key ([Username], [Title])
) 
go

go
Alter table [Note] add  foreign key([No]) references [NoteDB]([No])  on update cascade on delete cascade 
go
Alter table [Note] add  foreign key([Username]) references [LoginDB] ([Username])  on update cascade  on delete cascade  
go
Alter table [Note] add foreign key([Title]) references [NoteDB] ([Title]) on update cascade  on delete cascade 
go
Drop table [Note]
Drop table [NoteDB]
Drop table [LoginDB]


Set quoted_identifier on
go


Set quoted_identifier off
go


