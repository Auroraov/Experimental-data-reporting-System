Create view e_l
as	
Select experiment.ename,etime,etname,lname,ladd,lpho
from experiment,lab
where experiment.ename=lab.ename;