create database stackoverflow;

use stackoverflow;

create table question (
id int not null auto_increment,
username varchar(15) not null,
title varchar(30) not null,
detail varchar(200) not null,
posted datetime not null default NOW(),
category varchar(10) not null,
tags varchar(10) not null,
status int not null,
primary key(id)
);

create table answer (
id int not null auto_increment,
username varchar(15) not null,
detail varchar(200) not null,
questionId int not null,
posted datetime not null default NOW(),
upvotes int not null,
primary key(id),
foreign key (questionId) references question(id) 
);

insert into question (username, title, detail, posted, category, tags, status) values ('dev1','Outlook Question','Where do you find Outlook?','1998-01-23 12:45:56','SOFTWARE', 'MSOffice', 1);
insert into question (username, title, detail, posted, category, tags, status) values ('dev2','SQL Question','How do you create a table?','2010-12-31 01:15:00','SOFTWARE', 'SQL', 1);
insert into question (username, title, detail, posted, category, tags, status) values ('dev1','Git Hub Clone','How do you clone a git respository?','1998-01-23 12:45:56','SOFTWARE', 'Clone', 1);
insert into question (username, title, detail, posted, category, tags, status) values ('dev2','MySql DateTime Default','How do you create your MySql table with a default dateTime that populates automatically?','1998-01-23 12:45:56','SOFTWARE', 'SQL', 1);

insert into answer (username, detail, questionId, posted, upvotes) values ('tfecto','You find Outlook in your Start menu.',1,'2021-09-21 16:30:00', 0);
insert into answer (username, detail, questionId, posted, upvotes) values ('tfecto','To create a table in MySql you use the Create Table statement',2,'2021-09-21 16:41:00', 0);
insert into answer (username, detail, questionId, posted, upvotes) values ('tfecto','You find Outlook in the Start menu under the Office icons, in Windows10.',1,'2021-09-21 16:52:00', 0);
