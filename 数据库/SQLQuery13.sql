 
 create trigger 创建学生新用户
  on zhanghao
  for insert
  as
   declare @snumber char(10)
   begin
       select @snumber=snu from inserted
	   insert into zhanghao
	   values(@snumber,'12345')
 
 
  end