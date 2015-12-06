CREATE TABLE [dbo].[Orientador_Projeto]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Orientador] INT NOT NULL, 
    [Id_Projeto] INT NOT NULL, 
    CONSTRAINT [FK_Orientador_Projeto_Projeto] FOREIGN KEY ([Id_Orientador]) REFERENCES [Professor]([Id]), 
    CONSTRAINT [FK_Orientador_Projeto_Professor] FOREIGN KEY ([Id_Projeto]) REFERENCES [Projeto]([Id])
)
