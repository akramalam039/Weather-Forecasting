create database Weather
use Weather
create table Registration_tbl(
fname varchar (20) not null,
lname varchar (20),
username varchar(29) not null,
password varchar(50) not null,
gender varchar(10),
date_brth varchar(10),
country varchar(10),
phone_number bigint not null,
primary key(username)
)
insert into Registration_tbl (fname,lname,username,password,gender,date_brth,country,phone_number)  values('akram','alam','akramalam039@gmail.com','1234','Male','20-12-2000','India',9891044328)

select *from Registration_tbl