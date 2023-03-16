create trigger 实验上报
on experiment 
for update
as 
	if update(ename)
	begin 
	update experiment
	set ename=i.ename
	from deleted d,inserted i, experiment e
	where e.ename=d.ename
	end

	begin
	update student
	set sno=i.sno
	from deleted d, inserted i,student s
	where s.sno=d.sno
	end