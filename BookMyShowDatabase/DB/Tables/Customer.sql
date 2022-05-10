CREATE TABLE [dbo].[Customer]
(
	Id int not null IDENTITY(1,1) primary key,
	CustomerName nvarchar not null,
	Email nvarchar not null,
	PhoneNumber nvarchar not null,
	CityId int not null
)
