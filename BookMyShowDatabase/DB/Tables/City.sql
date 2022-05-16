CREATE TABLE [dbo].[City]
(
	Id int not null IDENTITY(1,1) primary key,
	CityName nvarchar not null,
	Pincode nvarchar not null,
	IsDeleted bit not null,
	DayDeleted date,
)
