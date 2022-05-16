CREATE TABLE [dbo].[CustomerSeat]
(
	Id int not null IDENTITY(1,1) primary key,
	Price int not null,
	TheaterSeatId int not null,
	BookingId int not null,
	IsDeleted bit not null,
	DayDeleted date,
)
