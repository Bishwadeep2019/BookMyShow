CREATE TABLE [dbo].[Show]
(
	Id int not null IDENTITY(1,1) primary key,
	StartTime nvarchar not null,
	EndTime nvarchar not null,
	ShowDate date not null,
	HallId int not null,
	MovieID int not null
)
