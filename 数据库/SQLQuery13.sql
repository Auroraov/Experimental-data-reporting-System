 
 create trigger ����ѧ�����û�
  on zhanghao
  for insert
  as
   declare @snumber char(10)
   begin
       select @snumber=snu from inserted
	   insert into zhanghao
	   values(@snumber,'12345')
 
 
  end