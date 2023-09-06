Create database Addressbook_service;
use Addressbook_service;

drop table AddressBook;

Create table AddressBook(
id int primary key identity(1,1),
firstname varchar(30),
lastname varchar(30),
address varchar(30),
city varchar(30),
state varchar(30),
zip varchar(6),
phonenumber varchar(10),
email varchar(30)
); 

select * from AddressBook;

--Create Stored Procedures
Create Procedure AddContactDetails(
@firstname varchar(20),
@lastname varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20),
@zip bigint,
@phonenumber varchar(10), 
@email varchar(30) 
)
As
begin
insert Into AddressBook(firstname,lastname,address,city,state,zip,phonenumber,email) values(@firstname,@lastname,@address,@city,@state,@zip,@phonenumber,@email);
End

 

Create Procedure EditContactDetails(
@firstname varchar(30),
@lastname varchar(30),
@address varchar(30),
@city varchar(20),
@state varchar(20),
@zip bigint,
@phonenumber varchar(10), 
@email varchar(30) 
)
As
begin
update AddressBook set firstname=@firstname,lastname=@lastname,address=@address,city=@city,state=@state,zip=@zip,phonenumber=@phonenumber,email=@email where firstname=@firstname
End

 

Create Procedure DeleteContactDetails(
@firstname varchar(20)
)
As
Begin Delete from AddressBook where firstname=@firstname
End

 

Create Procedure DetailsinCity(
@city varchar(20)
)
As
Begin Select * from AddressBook where city=@city order by firstname 
End

Create Procedure DetailsinState(
@state varchar(20)
)
As
Begin Select * from AddressBook where state=@state order by firstname 
End

 

Create Procedure CountinCity
As
Begin Select city, count(*)as count from AddressBook group by city
End

 

 Create Procedure CountinState
As
Begin Select state, count(*)as count from AddressBook group by state
End

 Create table Type(
id int primary key identity(1,1),
type varchar(20)
);

Insert into Type Values('Family');
Insert into Type Values('Friends');
Insert into Type Values('Profession');
Insert into Type Values('Others');

 select * from Type;
 
 Alter table AddressBook
Add type varchar(20);

 

 --uc10
Create Procedure CountByType
As
Begin
Select type, count(*) as count from AddressBook group by type 
End

 

--UC11
Create Procedure AddValues(
@Contactid int,
@Typeid int
)
As
Begin
Insert into AddressBook(contactid,typeid) values(@Contactid,@Typeid)
End

 

Select * from AddressBook;

Create Procedure AddPersonValues(
@contactId int,
@type int
)
As
Begin
Insert into AddPerson values(@contactId,@type)
End


Select * from AddressBook
Select * from AddPerson

Alter Table AddressBook drop column type;
Alter table AddressBook Add type varchar(20);