CREATE TABLE [dbo].[City]
(
	Id int not null IDENTITY(1,1) primary key,
	CityName nvarchar(255) not null,
	Pincode nvarchar(255) not null,
	IsDeleted bit not null,
	DateDeleted date,
)
