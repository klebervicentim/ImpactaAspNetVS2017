create procedure tarefaInserir  
   @nome nvarchar(200), 
   @prioridade int,
   @concluida bit,
   @observacao nvarchar(1000)
as 
  begin
    insert into tarefa(nome, prioridade, Concluida, observacao) 
	output inserted.Id
	values(@nome,@prioridade, @concluida, @observacao)

  end