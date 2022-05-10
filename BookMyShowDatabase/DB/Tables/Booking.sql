CREATE TABLE [dbo].[Booking]
(
	Id int not null IDENTITY(1,1) primary key,
	RequiredSeats int not null,
	BookingDate date not null,
	CustomerId int not null,
	ShowId int not null
)
