create table lab(
lname char(10) primary key,
ladd char(10),
lpho char(20),
ename char(10),
foreign key (ename) references experiment (ename) );