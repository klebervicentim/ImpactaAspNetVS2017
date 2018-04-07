CREATE TABLE [dbo].[tarefa] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (200)  NOT NULL,
    [Prioridade] INT             DEFAULT ((0)) NULL,
    [Concluida]  BIT             NULL,
    [Observacao] NVARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

