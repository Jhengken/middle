--------------------------create database---------------------
drop database if exists Middle

create database Middle
on primary
	(name= 'Middle', filename= 'C:\MiddleDB\Middle.mdf',
	size= 8MB, maxsize= unlimited, filegrowth = 4MB),
filegroup secondary 
	(name = 'Middle_ndf', filename = 'C:\MiddleDB\Middle_ndf.ndf',
	size = 8MB, maxsize = unlimited)
log on
	(name = 'Middle_Idf', filename = 'C:\MiddleDB\Middle_Idf.Idf',
	size = 8MB, maxsize = 2GB, filegrowth = 4Mb)
go

create schema mid;   --µ²ºc´y­z
go

------------------------Create table-----------------------------------------------
use Middle

drop table if exists Employees        --Employees
Create table Employees(
		EmployeeID int identity(1,1),
		Name nvarchar(20) not null,
		BirthDate datetime not null,
		HireDate datetime not null,
		Address nvarchar(100) not null,
		Phone nvarchar(15) not null,
		Account nvarchar(30)not null,
		PassWord nvarchar(30)not null,
		Role nvarchar(20) default 'Staff',
		constraint UQ_EmAccount unique (Account),
		constraint PK_EmployeeID primary key clustered (EmployeeID asc))
go

drop table if exists Customers   --Customer
Create table Customers(
		CustomerID int identity(1,1),
		Name nvarchar(20) not null,
		BirthDate datetime,
		Address nvarchar(100) ,
		Phone nvarchar(15) not null,
		Account  nvarchar(30)not null,
		Passwork nvarchar(30)not null,
		constraint UQ_CusAccount unique (Account) ,
		constraint PK_CustomerID primary key clustered (CustomerID asc))
go

drop table if exists Products   --Products
Create table Products(
		ProductID int identity(1,1),
		ProductName nvarchar(50) not null,
		CategoryName nvarchar(50) not null,
		CategoryID int not null,
		Description nvarchar(100),
		UnitPrice int not null,
		Picture nvarchar(100),
		Popular bit default 0,
		constraint PK_ProductID primary key (ProductID asc))
go

drop table if exists Orders   --Orders
create table Orders(
		OrderID int identity(1,1),
		CustomerID int,
		OrderDate datetime default sysdatetime() not null,
		TakeDate datetime not null,
		ModifiedDate datetime,
		CompleteDate datetime,
		constraint PK_OrderID primary key(OrderID),
		constraint FK_Customer_CustomerID foreign key(CustomerID)
		references middle.dbo.Customers(CustomerID)
		on delete cascade
		on update cascade);
go


drop table if exists OrderDetails    --OrderDetail
Create table OrderDetails(
		OrderID int not null,
		ProductID int not null,
		Price int not null,
		Quantity int not null,
		constraint PK_Order_Details primary key(OrderID,ProductID),   --PK_Order_Details
		constraint FK_Orders_OrderID foreign key(OrderID)             --FK_Orders_OrderID
		references middle.dbo.Orders(OrderID)
		on delete cascade
		on update cascade,
		constraint FK_Products_ProductID foreign key(ProductID)        --FK_Products_ProductID
		references middle.dbo.Products(ProductID)
		on delete cascade
		on update cascade);
go