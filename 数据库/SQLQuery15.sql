 
create procedure �ϱ���ʵ��
@ename char(10),
@etime char(10),
@etname char(10)

as 
insert experiment(ename,etime,etname)
values(@ename,@etime,@etname)
select *
from experiment
go