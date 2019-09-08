create database WebFormsProject
go
use WebFormsProject
go

--use master drop database WebFormsProject

create table City
(
IDCity int primary key identity,
Name nvarchar(50) not null
)

create table [Status]
(
IDStatus int primary key identity,
Name nvarchar(50) not null
)

create table Person
(
IDPerson int primary key identity,
Name nvarchar(50) not null,
Surname nvarchar(50) not null,
Telephone nvarchar(50) null,
CityID int foreign key references City(IDCity) not null,
Password nvarchar(10) not null,
StatusID int foreign key references Status(IDStatus) not null

)

create table Email
(
IDEmail int primary key identity,
Email nvarchar(100) null,
PersonID int foreign key references Person(IDPerson) 
)

go

--PROCEDURES


--INSERT PERSON

create proc AddPerson 
@name nvarchar(50),
@surname nvarchar(50),
@telephone nvarchar(50),
@IDcity int,
@IDstatus int,
@password nvarchar(10)
as
	begin
	insert into Person values
	(@name, @surname, @telephone, @IDcity, @password, @IDstatus)	
	end
go

--INSERT EMAIL
create proc AddEmail
@IDPerson int,
@Email nvarchar(100)
as
begin

		insert into Email(Email, PersonID) values
		(@email, @IDPerson)
	
end
go

select * from Person
select * from Email

--SELECT

--create proc GetPersons
--as
--begin
--	select p.Name, p.Surname, e.Email, p.Telephone, s.Name from Person as p
--	left outer join Email as e
--	on p.IDPerson=e.PersonID
--	inner join Status as s
--	on p.StatusID=s.IDStatus
--	--zbog admina
--	where IDPerson >1
--end
--go
create proc GetPersons
as
begin
	select * from Person
	--zbog admina
	where IDPerson >1
end
go

create proc GetPerson
@id int
as
begin
	select * from Person
	--zbog admina
	where IDPerson =@id
end
go

--DELETE

create proc DeletePerson
@IDPerson int
as
	begin
	if exists(select IDPerson from Person where IDPerson=@IDPerson)
	begin
	delete Email
	where PersonID=@IDPerson
	delete Person
	where IDPerson=@IDPerson
	
	end
	
	end
go

--UPDATE
--person
create proc EditPerson
@id int, 
@name nvarchar(50),
@surname nvarchar(50),
@telephone nvarchar(50),
@IDcity int,
@IDstatus int,
@password nvarchar(10)
as
begin
	if exists(select IDPerson from Person where IDPerson=@id)
	begin
		update Person set
		Name=@name,
		Surname=@surname,
		Telephone=@telephone,
		CityID=@IDcity,
		StatusID=@IDstatus,
		Password=@password
		where IDPerson=@id
		end
end
go

--email
create proc EditEmail
@old nvarchar(100),
@new nvarchar(100)
as
begin
	if exists(select Email from Email where Email=@old)
	begin
	update Email set
	Email=@new
	where Email=@old
	end
end
go

create proc GetEmailsPerPerson
@IDPerson int
as
select * from Email
where PersonID=@IDPerson

go

create proc GetCities
as
select * from City

go

create proc GetStatuses
as
select * from Status
go



create proc CheckIfEmailExists
@email nvarchar(100)
as
select * from Email where Email=@email
go

create proc GetLoginData
@personID int,
@password nvarchar(10)
as
select * from Person 
where IDPerson=@personID and Password=@password
go

--create proc GetPassword
--@IDPerson int
--as
--select * from Person

create proc GetCity
@id int
as
select* from City
where IDCity=@id
go

create proc GetStatus
@id int
as
select * from Status
where IDStatus=@id
go

create proc GetPersonAfterInsert
@name nvarchar(25),
@surname nvarchar(25),
@pass nvarchar(10)
as
select * from Person
where Name=@name and Surname=@surname and Password=@pass
go

--INITIAL DATA
insert into City values
('Zagreb'),
('Varaždin'),
('Rijeka'),
('Split')

go

insert into Status values
('Admin'),
('User')

go

insert into Person values
('Admin', 'Admin', null, 1, '123',1),
('Pero', 'Periæ', null, 1, '123',1)

GO 

insert into Email values
('admin@email.com',1),
('pero@email.com',2)

--exec DeletePerson 1


