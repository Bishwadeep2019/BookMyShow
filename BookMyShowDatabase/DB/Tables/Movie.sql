CREATE TABLE [dbo].[Movie]
(
	Id int not null IDENTITY(1,1) primary key,
	Title nvarchar not null,
	ReleaseDate date not null,
	Language nvarchar not null,
	MovieImageUrl nvarchar not null,
	Genre nvarchar not null,
	Duration nvarchar not null
)
