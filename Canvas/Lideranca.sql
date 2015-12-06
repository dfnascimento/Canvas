CREATE TABLE [dbo].[Lideranca]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Aluno] INT NOT NULL, 
    [Id_Projeto] INT NOT NULL, 
    [Data_Inicio] DATE NOT NULL, 
    [Data_Final] DATE NULL, 
    CONSTRAINT [FK_Lideranca_Aluno] FOREIGN KEY ([Id_Aluno]) REFERENCES [Aluno]([Id]), 
    CONSTRAINT [FK_Lideranca_Projeto] FOREIGN KEY ([Id_Projeto]) REFERENCES [Projeto]([Id])
)
