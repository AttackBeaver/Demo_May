
create table Roles(
Role_ID int identity(1,1) primary key,
Role_Title nvarchar(100))

create table Users(
[User_ID] int identity(1,1) primary key,
Role_ID int foreign key references Roles(Role_ID),
User_Surname nvarchar(max),
[User_Name] nvarchar(max),
User_Lastname nvarchar(max),
User_Phone nvarchar(max),
User_Login nvarchar(max),
User_Password nvarchar(max))

create table Tech_Type(
TechType_ID int identity(1,1) primary key,
TechType_Title nvarchar(100))

create table Requests_Status(
Status_ID int identity(1,1) primary key,
Status_Title nvarchar(100))

create table Requests(
Request_ID int identity(1,1) primary key,
TechType_ID int foreign key references Tech_Type(TechType_ID),
Request_StartDate date,
Request_TechModel nvarchar(max),
Request_Problem nvarchar(max),
Status_ID int foreign key references Requests_Status(Status_ID),
Request_CompletionDate date,
Request_RepairParts nvarchar(max),
Master_ID int foreign key references Users([User_ID]),
Client_ID int foreign key references Users([User_ID]))

create table Comments(
Comment_ID int identity(1,1) primary key,
Comment_Message nvarchar(max),
Master_ID int foreign key references Users([User_ID]),
Request_ID int foreign key references Requests(Request_ID))

alter proc sp_FullRequest
as
select Tech_Type.TechType_Title as [Тип],Requests.Request_StartDate as [Прием заявки],Requests.Request_TechModel as [Модель],Requests.Request_Problem as [Проблема],
Requests_Status.Status_Title as [Статус],Requests.Request_CompletionDate as [Дата выполнения],Requests.Request_RepairParts as [Запчасти],
M.User_Surname+' '+M.[User_Name]+' '+M.User_Lastname as [Мастер],
C.User_Surname+' '+C.[User_Name]+' '+C.User_Lastname as [Клиент],
Comments.Comment_Message as [Комментарий]
from Requests left join Tech_Type on Requests.TechType_ID = Tech_Type.TechType_ID
left join Requests_Status on Requests.Status_ID = Requests_Status.Status_ID
left join Users M on Requests.Master_ID = M.[User_ID]
left join Users C on Requests.Client_ID = C.[User_ID]
left join Comments on Requests.Request_ID = Comments.Request_ID

exec sp_FullRequest

select*from Users where Role_ID = '1'
select*from Roles
select*from Requests
select*from Tech_Type
select*from Requests_Status

create proc sp_AddRequest
@type int,@startdate date,@model nvarchar(max),@problem nvarchar(max),@status int,@compdate date,
@parts nvarchar(max),@master int,@client int
as
begin
	insert into Requests(TechType_ID,Request_StartDate,Request_TechModel,Request_Problem,Status_ID,Request_CompletionDate,Request_RepairParts,Master_ID,Client_ID)
	values (@type,@startdate,@model,@problem,@status,@compdate,@parts,@master,@client)
end

exec sp_AddRequest '','','','','','','','',''

create proc sp_Users
as
select Roles.Role_Title as [Роль в системе],Users.User_Surname+' '+Users.User_Name+' '+Users.User_Lastname as [ФИО],Users.User_Phone as [Телефон],
Users.User_Login as [Логин],Users.User_Password as [Пароль]
from Users inner join Roles on Users.Role_ID = Roles.Role_ID

exec sp_Users

create proc sp_AddRoles
@title nvarchar(max)
as
begin
	insert into Roles(Role_Title)
	values(@title)
end

exec sp_AddRoles ''

create proc sp_AddUsers
@role int,@surname nvarchar(max),@name nvarchar(max),@lastname nvarchar(max),@phone nvarchar(max),@login nvarchar(max),@pass nvarchar(max)
as
begin
	insert into Users(Role_ID,User_Surname,User_Name,User_Lastname,User_Phone,User_Login,User_Password)
	values(@role,@surname,@name,@lastname,@phone,@login,@pass)
end

exec sp_AddUsers '','','','','','',''