CREATE TABLE [dbo].[Customer]
(
	Id int not null IDENTITY(1,1) primary key,
	CustomerName nvarchar(255) not null,
	Email nvarchar(255) not null,
	PhoneNumber nvarchar(255) not null,
	CityId int not null,
	IsDeleted bit not null,
	DateDeleted date,
)
