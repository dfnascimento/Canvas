CREATE TABLE [dbo].[Avaliador_Projeto]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Avaliador] INT NOT NULL, 
    [Id_Projeto] INT NOT NULL, 
    [Status] VARCHAR(20) NOT NULL, 
    CONSTRAINT [FK_Avaliador_Projeto_Avaliador] FOREIGN KEY ([Id_Avaliador]) REFERENCES [Avaliador_Externo]([Id]), 
    CONSTRAINT [FK_Avaliador_Projeto_Projeto] FOREIGN KEY ([Id_Projeto]) REFERENCES [Projeto]([Id])
)
