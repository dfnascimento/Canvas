CREATE TABLE [dbo].[Aluno_Projeto]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Projeto] INT NOT NULL, 
    [Id_Aluno] INT NOT NULL, 
    CONSTRAINT [FK_Aluno_Projeto_Projeto] FOREIGN KEY ([Id_Projeto]) REFERENCES [Projeto]([Id]), 
    CONSTRAINT [FK_Aluno_Projeto_Aluno] FOREIGN KEY ([Id_Aluno]) REFERENCES [Aluno]([Id])
)
