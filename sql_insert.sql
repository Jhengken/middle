------------------Insert Customers----------------------------------
insert Customers values('�����X', '1994-08-08', '�x�n���n��', '0911111111', 'aa123456', 'aa123456'),
										('���ɬu', '1995-09-07', '�x�n���k����', '0922222222',  'bb123456', 'bb123456'),
										('������', '1998-12-07', '�x�n���F��', '0933333333',  'cc123456', 'cc123456'),
										('�L�ѻ�', '1990-01-24', '�x�n�������', '0944444444',  'dd123456', 'dd123456'),
										('�G���s', '1996-02-08', '�x�n���k����', '0955555555',  'ee123456', 'ee123456'),
										('�H�P�F', '1993-11-17',  '�x�n���F��', '0934343434', 'ff123456', 'ff123456'),
										('�~�M', null, null, '0966666666','gg123456', 'gg123456'),
										('�i�ũ�', '1985-06-16',  '�x�n�������', '0945454545', 'hh123456', 'hh123456');
go

------------------Insert Employees----------------------------------
insert Employees values('�i�ũ�', '1985-06-16', '2015-06-06', '�x�n�������', '0945454545', 'e20150606', 'e1234567',  'Boss'),
										('�B�[��', '1989-05-13', '2016-06-01', '�x�n�����w��', '0923232323', 'e20160601', 'e1234567',  'CEO'),
										('�H�P�F', '1993-11-17', '2016-11-13', '�x�n���F��', '0934343434', 'e20161113', 'e1234567',  'Staff'),
										('�L����', '1991-07-09', '2021-08-09', '�x�n���n��', '0912121212', 'e20210809', 'e1234567', 'Staff');
go
--alter table Employees
--add Account varchar(30)not null,

------------------Insert Products----------------------------------
insert Products values('�_�q�J', 'Sub', 1, '�n�Y���_�q�縥��', 80, 'Sub_CheeseEgg.png', 0),
									('�N�L���d��', 'Sub', 1, '�n�Y���N�L���d��縥��', 90, 'Sub_Falafel.png', 0),
									('�N�N����', 'Sub',  1,'�n�Y���N�N���׼縥��', 100, 'Sub_RoastBeef.png', 1),
									('��������', 'Sub',  1,'�n�Y�����������縥��', 110, 'Sub_Shrimp.png', 0),
									('�Y���M��', 'Sub',  1,'�n�Y���Y���M�μ縥��', 85, 'Sub_Vagetable.png', 0),
									('���ڳJ��', 'EggCake',  2,'�n�Y�����ڳJ��', 35 ,'EggCake_Bacon.png', 0),
									('�t���J��', 'EggCake',  2,'�n�Y���t���J��', 35 ,'EggCake_Chicken.png', 0),
									('�ɦ̳J��', 'EggCake',  2,'�n�Y���ɦ̳J��', 30 ,'EggCake_Corn.png', 0),
									('�C���J��', 'EggCake',  2,'�n�Y���C���J��', 35 ,'EggCake_Fish.png', 0),
									('���ٳJ��', 'EggCake',  2,'�n�Y�����ٳJ��', 45 ,'EggCake_Pig.png', 0),
									('���̪�', 'Single',  3,'�n�Y�����̪�', 30, 'Single_ChickenPopcorn.png', 0),
									('�ɦ̿@��', 'Single', 3,'�n�ܪ��ɦ̿@��', 30, 'Single_CornSoup.png', 0),
									('�λ�', 'Single', 3, '�n�Y���λ�', 40, 'Single_dumpling.png', 1),
									('�γJ', 'Single', 3, '�n�Y���γJ', 15, 'Single_FriedEgg.png', 0),
									('����', 'Single', 3, '�n�Y������', 20, 'Single_PotatoCake.png', 0),
									('�i�i��', 'Drink', 4, '�n�ܪ��i�i��', 25, 'Drink_Cocoa.png', 0),
									('���K', 'Drink', 4, '�n�ܪ����K', 35, 'Drink_CoffeeMilk.png', 0),
									('�W���A����', 'Drink', 4, '�n�ܪ��W���A����', 25, 'Drink_MilkTea.png', 1),
									('����', 'Drink', 4, '�n�ܪ�����', 25, 'Drink_RedTea.png', 0),
									('�@�@����', 'Drink', 4, '�n�ܪ��@�@����', 25, 'Drink_SoyMilk.png', 0);
go