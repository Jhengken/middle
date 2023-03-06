---------創建proc_ModifiedProduct============================

drop proc if exists proc_ModifiedProduct;
create proc proc_ModifiedProduct @ProductName nvarchar(50), @CategoryName nvarchar(50), @CategoryID int, @Description nvarchar(100), @UnitPrice int, @Picture nvarchar(100), @Popular bit       --7個變數
with encryption
as
set nocount on
	update Products set ProductName=@ProductName, CategoryName=@CategoryName, CategoryID=@CategoryID, Description=@Description, UnitPrice=@UnitPrice, Picture=@Picture, Popular=@Popular

select * from Products
---------創建proc_AddProduct============================

drop proc if exists proc_AddProduct;
create proc proc_AddProduct @ProductName nvarchar(50), @CategoryName nvarchar(50), @CategoryID int, @Description nvarchar(100), @UnitPrice int, @Picture nvarchar(100), @Popular bit       --1個變數        --7個變數
with encryption
as
set nocount on
	insert Products values (@ProductName, @CategoryName, @CategoryID, @Description, @UnitPrice, @Picture, @Popular )


---------創建proc_DeleteProduct============================

drop proc if exists proc_DeleteProduct;
create proc proc_DeleteProduct @ProductID int         --1個變數
with encryption
as
set nocount on
	delete Products where ProductID = @ProductID
