CREATE TABLE [dbo].[Movie]
(
	Id int not null IDENTITY(1,1) primary key,
	Title nvarchar(255) not null,
	ReleaseDate date not null,
	Language nvarchar(255) not null,
	MovieImageUrl nvarchar(255) not null,
	Genre nvarchar(255) not null,
	Duration nvarchar(255) not null,
	IsDeleted bit not null,
	DateDeleted date,
)
