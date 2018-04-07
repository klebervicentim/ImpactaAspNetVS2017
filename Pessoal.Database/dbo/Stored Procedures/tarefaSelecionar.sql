create procedure tarefaSelecionar @Id int = null
as 
begin
   
   select Id, Nome, Prioridade, Concluida, Observacao 
   from tarefa
   where id = ISNULL(@id, id)
   order by concluida, prioridade, nome

end
