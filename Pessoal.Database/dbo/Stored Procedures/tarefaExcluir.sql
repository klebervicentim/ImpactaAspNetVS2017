create procedure tarefaExcluir @Id int 
as 
begin
  delete from tarefa where id = @Id 
end


