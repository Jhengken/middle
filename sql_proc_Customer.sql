--proc_Logic
--proc_LogicName
--proc_InsertOrders
--proc_InsertOrdersNull
--proc_Insert_OrderDetails

-------創建proc_Logic============================

drop proc if exists proc_Logic;
create proc proc_Logic @acont nvarchar(30), @pswd nvarchar(30), @Level int output
with encryption
as
set nocount on
if (@acont = any(select Account from Customers) and @pswd = any(select Passwork from Customers where Account = @acont))  --資料庫有沒有customer跟Employees一樣名字電話的
	if ((select Name from Customers where Account = @acont) = any(select Name from Employees) and (select Phone from Customers where Account = @acont) = any(select Phone from Employees))   --判斷是不是員工
		set @Level = 2
	else 
		set @Level = 1
else 
	set @Level = 0;

-----測試
declare @acont nvarchar(30) ='ff123456', @pswd nvarchar(30)='ff123456',@Level int    --不是會員0，會員1，管理員2
exec proc_Logic @acont, @pswd,@Level output
print cast(@Level as varchar)




-------創建proc_LogicName============================

drop proc if exists proc_LogicName;    --四個變數
create proc proc_LogicName @acont nvarchar(30), @Name nvarchar(30) output, @Phone nvarchar(30) output, @CustomerID int output
with encryption
as
set nocount on
select @Name = Name from Customers where Account = @acont;
select @Phone = Phone from Customers where Account = @acont;
select @CustomerID = CustomerID from Customers where Account = @acont;


-----測試
declare @acont nvarchar(30) ='ff123456', @Name nvarchar(30) , @Phone nvarchar(30), @CustomerID int
exec proc_LogicName @acont, @Name output,@Phone output,@CustomerID output
select @Name,@Phone,@CustomerID

------------------Insert Orders============================

-------創建proc_InsertOrders============================select * from Orders

drop proc if exists proc_InsertOrders;                --創建proc_InsertOrders
create proc proc_InsertOrders @CustomerID int, @TakeDate datetime,@OrderID int output       --2個變數
with encryption
as
set nocount on
	insert Orders (CustomerID, OrderDate, TakeDate) values (@CustomerID, sysdatetime(), @TakeDate);   --進訂單
	select top(1) @OrderID = OrderID from Orders order by OrderID desc

---測試
declare @CustomerID int =7, @TakeDate datetime = convert(varchar,dateAdd(hour,1,sysdatetime()),100),@OrderID int;                       --測試proc_InsertOrders
exec proc_InsertOrders @CustomerID, @TakeDate, @OrderID output;
select @OrderID
--select convert(varchar, getdate(), 100);                -- mon dd yyyy hh:mmAM (or PM)  -- 10  2 2008 11:01AM時間轉換字串
--select  convert(varchar,dateAdd(hour,1,sysdatetime()),100)

-------創建proc_InsertOrdersNull============================select * from Orders

drop proc if exists proc_InsertOrdersNull;                --創建proc_InsertOrders
create proc proc_InsertOrdersNull  @TakeDate datetime,@OrderID int output       --2個變數
with encryption
as
set nocount on
	insert Orders (CustomerID, OrderDate, TakeDate) values (null, sysdatetime(), @TakeDate);   --進訂單
	select top(1) @OrderID = OrderID from Orders order by OrderID desc

declare  @TakeDate datetime = convert(varchar,dateAdd(hour,1,sysdatetime()),100),@OrderID int;                       --測試proc_InsertOrders
exec proc_InsertOrdersNull  @TakeDate, @OrderID output;
select @OrderID

------------------Insert OrderDetails============================

---------創建proc_Insert_OrderDetails--------select * from OrderDetails
drop proc if exists proc_Insert_OrderDetails;
create proc proc_Insert_OrderDetails @OrderID int, @ProductID int, @Quantity int  --3個變數
with encryption
as
set nocount on
	insert OrderDetails values(@OrderID, @ProductID, (select UnitPrice from Products where ProductID = @ProductID) * @Quantity, @Quantity);

-----測試proc_Insert_OrderDetails
declare @OrderID int = 4, @ProductID int = 6, @Quantity int = 1
exec proc_Insert_OrderDetails @OrderID ,@ProductID, @Quantity




--select * from OrderDetails
--select * from Orders
select * from sys.procedures where type = 'P'    --看看資料庫有哪些procedures