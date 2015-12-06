CREATE TABLE [dbo].[Professor]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Participante] INT NOT NULL, 
    [Disciplina_Principal] VARCHAR(20) NOT NULL, 
    [Departamento] VARCHAR(20) NOT NULL, 
    CONSTRAINT [FK_Professor_Participante] FOREIGN KEY ([Id_Participante]) REFERENCES [Participante]([Id])
)
