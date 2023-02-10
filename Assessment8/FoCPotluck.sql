create database FoCPotluck;

use FoCPotluck;

create table TeamMember (
id int not null auto_increment,
FirstName varchar(50) not null,
LastName varchar(50) not null,
EmailAddress varchar(50) not null,
AttendanceDate varchar(50) not null,
GuestName varchar(50) not null,
primary key(id)
);

create table Dish (
id int not null auto_increment,
TMName varchar(50) not null,
PhoneNumber varchar(25) not null,
DishName varchar(50) not null,
DishDescription varchar(100) not null,
Category varchar(25) not null,
primary key(id)
);

insert into TeamMember (FirstName, LastName, EmailAddress, AttendanceDate, GuestName) values ('Todd','Fecto','toddfecto@rocketmortgage.com','10/02/2021 1:00 PM','Teresa');
insert into TeamMember (FirstName, LastName, EmailAddress, AttendanceDate, GuestName) values ('David','Sutten','dsutten@gmail.com','10/03/2021 1:00 PM','Karen');
insert into TeamMember (FirstName, LastName, EmailAddress, AttendanceDate, GuestName) values ('Jim','Vansicle','jvansicle@gmail.com','10/09/2021 12:00 PM','Laurie');
insert into TeamMember (FirstName, LastName, EmailAddress, AttendanceDate, GuestName) values ('Ismael','Venegas','ivenegas@gmail.com','10/10/2021 12:00 PM','Kristen');


insert into Dish (TMName, PhoneNumber, DishName, DishDescription, Category) values ('Todd Fecto','440-864-1356','Reeses Peanut Buttercup Brownies','Brownies with a chocolate chip cookie base and a miniature Reeses in the middle.','DESSERT');
insert into Dish (TMName, PhoneNumber, DishName, DishDescription, Category) values ('David Sutten','469-804-1957','Chicken Alfredo','Chicken chunks with pasta in an Alfredo sauce.','MAIN DISH');
insert into Dish (TMName, PhoneNumber, DishName, DishDescription, Category) values ('Jim Vansicle','312-821-7634','Apple Pecan Salad','Salad containg lettuce, tomatoes, pecans, apples, cranberries in a Pomegranate vinagarette dressing.','SALAD');
insert into Dish (TMName, PhoneNumber, DishName, DishDescription, Category) values ('Ismael Venegas','715-428-9416','Iced Tea','Lemonade Ice Tea','BEVERAGE');

