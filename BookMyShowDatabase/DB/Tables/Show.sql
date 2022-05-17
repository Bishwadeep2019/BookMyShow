CREATE TABLE [dbo].[Show]
(
	Id int not null IDENTITY(1,1) primary key,
	StartTime nvarchar(255) not null,
	EndTime nvarchar(255)  not null,
	ShowDate date not null,
	HallId int not null,
	MovieID int not null,
	IsDeleted bit not null,
	DateDeleted date,
)
