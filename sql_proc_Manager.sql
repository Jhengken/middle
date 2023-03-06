--proc_AddEmployees
--proc_ModifiedEmployees
--proc_DeleteEmployees

-------�Ы�proc_AddEmployees========================�P�_����return 0

drop proc if exists proc_AddEmployees;                --�Ы�proc_InsertOrders     --8���ܼ�
create proc proc_AddEmployees @Name nvarchar(20), @BirthDate datetime, @HireDate datetime, @Address nvarchar(100),  @Phone nvarchar(15), @Account nvarchar(30), @PassWord nvarchar(30), @Role nvarchar(20)
with encryption
as
set nocount on
	if not exists (select Account from Employees where Account = @Account)  --�b�����s�b
		if @Role = 'Boss'                                                                                        --�O���OBoss
			if not exists (select Role From Employees where Role = 'Boss')           --�S��Boss
				begin
				insert Employees values (@Name, @BirthDate, @HireDate, @Address, @Phone, @Account, @PassWord, @Role)
				return 1
				end
			else
				return 0
		else 
			begin
			insert Employees values (@Name, @BirthDate, @HireDate, @Address, @Phone, @Account, @PassWord, @Role)
			return 1
			end
	else
		return 0

---���� e20160601
declare @Name nvarchar(20) = '�\ʹ��', @BirthDate datetime = '1996-01-27', @HireDate datetime = '2022-01-01', @Address nvarchar(100) = '�x�n���k����',  @Phone nvarchar(15) = '0966006600', @Account nvarchar(30) = 'eGGGacc20220101', @PassWord nvarchar(30)= 'e1234567', @Role nvarchar(20) = 'staff', @put int
exec @put = proc_AddEmployees @Name , @BirthDate , @HireDate , @Address ,  @Phone , @Account , @PassWord , @Role 
select @put

select * from Employees
-------�Ы�proc_ModifiedEmployees========================

drop proc if exists proc_ModifiedEmployees;                --Account�bC#�P�_     --9���ܼ�
create proc proc_ModifiedEmployees @EmployeeID int, @Name nvarchar(20), @BirthDate datetime, @HireDate datetime, @Address nvarchar(100),  @Phone nvarchar(15), @Account nvarchar(30), @PassWord nvarchar(30), @Role nvarchar(20)
with encryption
as
set nocount on
	--if @Account != any(select Account from Employees)  --���F@Account���~��
		--begin
		update Employees set Name = @Name,BirthDate = @BirthDate,HireDate = @HireDate,Address =  @Address,Phone = @Phone, Account = @Account,PassWord = @PassWord,Role = @Role where EmployeeID = @EmployeeID
		--return 1
		--end
	--else
		--return 0
if @Account = any(select Account from Employees)
	print '1'
else 
	print '0'


---����
declare @EmployeeID int = 11,@Name nvarchar(20) = '��', @BirthDate datetime = '1996-08-27', @HireDate datetime = '2022-09-01', @Address nvarchar(100) = '�x�n����',  @Phone nvarchar(15) = '096600', @Account nvarchar(30) = 'e2t0150606', @PassWord nvarchar(30)= 'e1234567', @Role nvarchar(20) = 'staff', @put int
exec @put = proc_ModifiedEmployees @EmployeeID, @Name , @BirthDate , @HireDate , @Address ,  @Phone , @Account , @PassWord , @Role 
select @put

select * from Employees
-------�Ы�proc_DeleteEmployees========================

drop proc if exists proc_DeleteEmployees;                --Account�bC#�P�_     --1���ܼ�
create proc proc_DeleteEmployees @EmployeeID int
with encryption
as
set nocount on
	delete Employees where EmployeeID = @EmployeeID

-------�Ы�proc_========================
select * from orderdetails
-------�Ы�proc_========================



--select * from OrderDetails
--select * from Orders
select * from sys.procedures where type = 'P'    --�ݬݸ�Ʈw������procedures