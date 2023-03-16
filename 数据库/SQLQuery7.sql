Create view s_e	
as	
Select student.sno,sname,sage,spho,ename,etime,etname
from experiment,student
where experiment.sno=student.sno;
