--proc_Logic
--proc_LogicName
--proc_InsertOrders
--proc_InsertOrdersNull
--proc_Insert_OrderDetails

-------�Ы�proc_Logic============================

drop proc if exists proc_Logic;
create proc proc_Logic @acont nvarchar(30), @pswd nvarchar(30), @Level int output
with encryption
as
set nocount on
if (@acont = any(select Account from Customers) and @pswd = any(select Passwork from Customers where Account = @acont))  --��Ʈw���S��customer��Employees�@�˦W�r�q�ܪ�
	if ((select Name from Customers where Account = @acont) = any(select Name from Employees) and (select Phone from Customers where Account = @acont) = any(select Phone from Employees))   --�P�_�O���O���u
		set @Level = 2
	else 
		set @Level = 1
else 
	set @Level = 0;

-----����
declare @acont nvarchar(30) ='ff123456', @pswd nvarchar(30)='ff123456',@Level int    --���O�|��0�A�|��1�A�޲z��2
exec proc_Logic @acont, @pswd,@Level output
print cast(@Level as varchar)




-------�Ы�proc_LogicName============================

drop proc if exists proc_LogicName;    --�|���ܼ�
create proc proc_LogicName @acont nvarchar(30), @Name nvarchar(30) output, @Phone nvarchar(30) output, @CustomerID int output
with encryption
as
set nocount on
select @Name = Name from Customers where Account = @acont;
select @Phone = Phone from Customers where Account = @acont;
select @CustomerID = CustomerID from Customers where Account = @acont;


-----����
declare @acont nvarchar(30) ='ff123456', @Name nvarchar(30) , @Phone nvarchar(30), @CustomerID int
exec proc_LogicName @acont, @Name output,@Phone output,@CustomerID output
select @Name,@Phone,@CustomerID

------------------Insert Orders============================

-------�Ы�proc_InsertOrders============================select * from Orders

drop proc if exists proc_InsertOrders;                --�Ы�proc_InsertOrders
create proc proc_InsertOrders @CustomerID int, @TakeDate datetime,@OrderID int output       --2���ܼ�
with encryption
as
set nocount on
	insert Orders (CustomerID, OrderDate, TakeDate) values (@CustomerID, sysdatetime(), @TakeDate);   --�i�q��
	select top(1) @OrderID = OrderID from Orders order by OrderID desc

---����
declare @CustomerID int =7, @TakeDate datetime = convert(varchar,dateAdd(hour,1,sysdatetime()),100),@OrderID int;                       --����proc_InsertOrders
exec proc_InsertOrders @CustomerID, @TakeDate, @OrderID output;
select @OrderID
--select convert(varchar, getdate(), 100);                -- mon dd yyyy hh:mmAM (or PM)  -- 10  2 2008 11:01AM�ɶ��ഫ�r��
--select  convert(varchar,dateAdd(hour,1,sysdatetime()),100)

-------�Ы�proc_InsertOrdersNull============================select * from Orders

drop proc if exists proc_InsertOrdersNull;                --�Ы�proc_InsertOrders
create proc proc_InsertOrdersNull  @TakeDate datetime,@OrderID int output       --2���ܼ�
with encryption
as
set nocount on
	insert Orders (CustomerID, OrderDate, TakeDate) values (null, sysdatetime(), @TakeDate);   --�i�q��
	select top(1) @OrderID = OrderID from Orders order by OrderID desc

declare  @TakeDate datetime = convert(varchar,dateAdd(hour,1,sysdatetime()),100),@OrderID int;                       --����proc_InsertOrders
exec proc_InsertOrdersNull  @TakeDate, @OrderID output;
select @OrderID

------------------Insert OrderDetails============================

---------�Ы�proc_Insert_OrderDetails--------select * from OrderDetails
drop proc if exists proc_Insert_OrderDetails;
create proc proc_Insert_OrderDetails @OrderID int, @ProductID int, @Quantity int  --3���ܼ�
with encryption
as
set nocount on
	insert OrderDetails values(@OrderID, @ProductID, (select UnitPrice from Products where ProductID = @ProductID) * @Quantity, @Quantity);

-----����proc_Insert_OrderDetails
declare @OrderID int = 4, @ProductID int = 6, @Quantity int = 1
exec proc_Insert_OrderDetails @OrderID ,@ProductID, @Quantity




--select * from OrderDetails
--select * from Orders
select * from sys.procedures where type = 'P'    --�ݬݸ�Ʈw������procedures