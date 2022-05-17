CREATE TABLE [dbo].[Theater]
(
	Id int not null IDENTITY(1,1) primary key,
	TheaterName nvarchar(255) not null,
	TotalHall int not null,
	IsDeleted bit not null,
	DateDeleted date,
)
