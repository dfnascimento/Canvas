CREATE TABLE [dbo].[Aluno]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Participante] INT NOT NULL, 
    [Curso] VARCHAR(50) NOT NULL, 
    [Periodo] INT NOT NULL, 
    [Campus] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Aluno_Participante] FOREIGN KEY ([Id_Participante]) REFERENCES [Participante]([Id])
)
