create procedure tarefaAtualizar

   @Id int,	
   @nome nvarchar(200), 
   @prioridade int,
   @concluida bit,
   @observacao nvarchar(1000)

as 
begin

	update tarefa set 
	  nome = @nome,
	  prioridade = @prioridade, 
	  concluida =@concluida, 
	  observacao = @observacao 
	  where Id = @Id
end

