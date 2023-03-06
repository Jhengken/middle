--proc_AddEmployees
--proc_ModifiedEmployees
--proc_DeleteEmployees

-------創建proc_AddEmployees========================判斷失敗return 0

drop proc if exists proc_AddEmployees;                --創建proc_InsertOrders     --8個變數
create proc proc_AddEmployees @Name nvarchar(20), @BirthDate datetime, @HireDate datetime, @Address nvarchar(100),  @Phone nvarchar(15), @Account nvarchar(30), @PassWord nvarchar(30), @Role nvarchar(20)
with encryption
as
set nocount on
	if not exists (select Account from Employees where Account = @Account)  --帳號不存在
		if @Role = 'Boss'                                                                                        --是不是Boss
			if not exists (select Role From Employees where Role = 'Boss')           --沒有Boss
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

---測試 e20160601
declare @Name nvarchar(20) = '許妏綺', @BirthDate datetime = '1996-01-27', @HireDate datetime = '2022-01-01', @Address nvarchar(100) = '台南市歸仁區',  @Phone nvarchar(15) = '0966006600', @Account nvarchar(30) = 'eGGGacc20220101', @PassWord nvarchar(30)= 'e1234567', @Role nvarchar(20) = 'staff', @put int
exec @put = proc_AddEmployees @Name , @BirthDate , @HireDate , @Address ,  @Phone , @Account , @PassWord , @Role 
select @put

select * from Employees
-------創建proc_ModifiedEmployees========================

drop proc if exists proc_ModifiedEmployees;                --Account在C#判斷     --9個變數
create proc proc_ModifiedEmployees @EmployeeID int, @Name nvarchar(20), @BirthDate datetime, @HireDate datetime, @Address nvarchar(100),  @Phone nvarchar(15), @Account nvarchar(30), @PassWord nvarchar(30), @Role nvarchar(20)
with encryption
as
set nocount on
	--if @Account != any(select Account from Employees)  --除了@Account之外的
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


---測試
declare @EmployeeID int = 11,@Name nvarchar(20) = '綺', @BirthDate datetime = '1996-08-27', @HireDate datetime = '2022-09-01', @Address nvarchar(100) = '台南市區',  @Phone nvarchar(15) = '096600', @Account nvarchar(30) = 'e2t0150606', @PassWord nvarchar(30)= 'e1234567', @Role nvarchar(20) = 'staff', @put int
exec @put = proc_ModifiedEmployees @EmployeeID, @Name , @BirthDate , @HireDate , @Address ,  @Phone , @Account , @PassWord , @Role 
select @put

select * from Employees
-------創建proc_DeleteEmployees========================

drop proc if exists proc_DeleteEmployees;                --Account在C#判斷     --1個變數
create proc proc_DeleteEmployees @EmployeeID int
with encryption
as
set nocount on
	delete Employees where EmployeeID = @EmployeeID

-------創建proc_========================
select * from orderdetails
-------創建proc_========================



--select * from OrderDetails
--select * from Orders
select * from sys.procedures where type = 'P'    --看看資料庫有哪些procedures