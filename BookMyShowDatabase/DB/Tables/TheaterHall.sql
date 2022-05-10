CREATE TABLE [dbo].[TheaterHall]
(
	Id int not null IDENTITY(1,1) primary key,
	TotalSeats int not null,
	ShowID int not null,
	TheaterId int not null
)
