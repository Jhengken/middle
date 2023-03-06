--proc_MgLogic
--proc_QueryTop30
--proc_QueryCustomerName
--proc_QueryOrderID
--proc_ModifiedOrders
--proc_CompleteOrders
--proc_delete_OrderDetails
--proc_deleteRow_OrderDetails

-------�Ы�proc_MgLogic========================

drop proc if exists proc_MgLogic;
create proc proc_MgLogic @MgAcont nvarchar(30), @MgPswd nvarchar(30)
as
set nocount on
if (@MgAcont = any(select Account from Employees where Role = 'Boss') and @MgPswd = any(select PassWord from Employees where Role = 'Boss'))
	return 2
else if (@MgAcont = any(select Account from Employees) and @MgPswd = any(select PassWord from Employees where Account = @MgAcont))
			return 1
		else
			return 0

-----����
declare @B int, @MgAcont nvarchar(30) ='e20160601', @MgPswd nvarchar(30) ='e1234567'
exec @B =	 proc_MgLogic @MgAcont, @MgPswd
print cast(@B as varchar)

--�i�h�|����ܫe�X���q��
--DGV��OrderID CustomerName ProductName OrderDate TakeDate Quantity Price
--               detail       customers         products          Orders       Orders     detail     detail
--�R���q�檽���R��OrderID

-------proc_QueryTop30========================

drop proc if exists proc_QueryTop30;
create proc proc_QueryTop30   --0���ܼ�
with encryption
as
set nocount on
select od.OrderID, c.Name,p.ProductName, od.Quantity, od.Price, convert(varchar,o.OrderDate,100) as OrderDate, convert(varchar,o.TakeDate,100) as TakeDate
from OrderDetails as od
join Products as p on od.ProductID = p.ProductID
join Orders as o on od.OrderID =o.OrderID
join Customers as c on o.CustomerID = c.CustomerID
 where od.OrderID in (select top(30) OrderID from Orders order by orderiD desc) and o.CompleteDate  is null

-------����
exec proc_QueryTop30

--select * from Orders
--select * from OrderDetails
-------proc_QueryCustomerName==�e30��======================

drop proc if exists proc_QueryCustomerName;
create proc proc_QueryCustomerName @Name nvarchar(20)  --1���ܼ�
with encryption
as
set nocount on
select top(30) od.OrderID, c.Name,p.ProductName, od.Quantity, od.Price, convert(varchar,o.OrderDate,100) as OrderDate, convert(varchar,o.TakeDate,100) as TakeDate
from OrderDetails as od
join Products as p on od.ProductID = p.ProductID
join Orders as o on od.OrderID =o.OrderID
join Customers as c on o.CustomerID = c.CustomerID
where c.Name like '%'+@Name+'%'
return @@rowcount

-------����
declare @Name nvarchar(20) = '�s'
exec proc_QueryCustomerName @Name

-------proc_QueryOrderID==�e30��======================

drop proc if exists proc_QueryOrderID;
create proc proc_QueryOrderID @OrderID nvarchar(20)  --1���ܼ�
with encryption
as
set nocount on
select top(30) od.OrderID, c.Name,p.ProductName, od.Quantity, od.Price, convert(varchar,o.OrderDate,100) as OrderDate, convert(varchar,o.TakeDate,100) as TakeDate
from OrderDetails as od
join Products as p on od.ProductID = p.ProductID
join Orders as o on od.OrderID =o.OrderID
join Customers as c on o.CustomerID = c.CustomerID
where od.OrderID = @OrderID
return @@rowcount

-------����
declare @OrderID int = 2
exec proc_QueryOrderID @OrderID



---------�Ы�proc_ModifiedOrders============================

drop proc if exists proc_ModifiedOrders;
create proc proc_ModifiedOrders @OrderID int , @ProductName nvarchar(20), @Quantity int      --3���ܼ�
with encryption
as
set nocount on
	update OrderDetails set Quantity=@Quantity, Price=@Quantity*(select UnitPrice from Products where ProductID=(select ProductID from Products where ProductName  = @ProductName)) where OrderID=@OrderID and ProductID= (select ProductID from Products where ProductName  = @ProductName)
	update Orders set ModifiedDate = sysdatetime()                                                       --�ק�q��ɶ��A�W���o��n�Ψ�Products��ProductID�ҥH����c��
	where OrderID = @OrderID;

--����proc_ModifiedOrders
declare @OrderID int = 4, @ProductName nvarchar(20) = '���ڳJ��' , @Quantity int = 2
exec proc_ModifiedOrders @OrderID , @ProductName , @Quantity

---------�Ы�proc_CompleteOrders============================

drop proc if exists proc_CompleteOrders;            --�Ы�proc_CompleteOrders
create proc proc_CompleteOrders @OrderID int         --1���ܼ�
with encryption
as
set nocount on
	update Orders set CompleteDate = sysdatetime()      --�����q��
	where OrderID = @OrderID;

declare @OrderID int=8;                         --����proc_CompleteOrders
exec proc_CompleteOrders @OrderID


---------�Ы�proc_delete_OrderDetails============================select * from OrderDetails
drop proc if exists proc_delete_OrderDetails;
create proc proc_delete_OrderDetails @OrderID int  --1���ܼ�
with encryption
as
set nocount on
		delete OrderDetails where OrderID = @OrderID
		delete Orders where OrderID = @OrderID
	

declare @OrderID int = 12                    --����proc_delete_OrderDetails
exec proc_delete_OrderDetails @OrderID

---------�Ы�proc_deleteRow_OrderDetails============================select * from OrderDetails

drop proc if exists proc_deleteRow_OrderDetails;
create proc proc_deleteRow_OrderDetails @OrderID int, @ProductName nvarchar(30)  --2���ܼ�
with encryption
as
set nocount on
	delete OrderDetails where OrderID = @OrderID and ProductID = (select ProductID from Products where ProductName  = @ProductName)
	if not exists(select 0 from OrderDetails where OrderID = @OrderID)
			delete Orders where OrderID = @OrderID
	
declare @OrderID int =25, @ProductName nvarchar(30) = '�N�N����'            --����proc_deleteRow_OrderDetails
exec proc_deleteRow_OrderDetails @OrderID, @ProductName

--select * from Orders
--select * from OrderDetails

select * from sys.procedures where type = 'P'    --�ݬݸ�Ʈw������procedures