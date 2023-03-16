create table experiment(
ename char(10)primary key ,
etime char(10),
etname char(10),
sno char(10),

foreign key(sno) references student(sno));