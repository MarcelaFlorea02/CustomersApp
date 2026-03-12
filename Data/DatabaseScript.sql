--create database 

create database CustomersApp

--create Customer table 
create table Customer(
Id int identity(1,1) primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
Email varchar(100) not null unique,
Phone varchar(20) null,
CreatedAt datetime not null default getdate()
)


--insert values in the table 
insert into Customer (FirstName, LastName, Email, Phone)
values ('John','Doe','john.doe@test.com', '071111111'),
('Jane','Smith','jane.smith@test.com','077222222'),
('Alex','Popescu','alex.popescu@test.com','0766666666')

--retrive data 
select * from Customer
select * from Customer where LastName = 'Doe'

-- update 
update Customer
set Phone = '079999999'
where Email= 'john.doe@test.com'

--delete 
delete from Customer 
where Id = 3