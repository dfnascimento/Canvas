CREATE TABLE [dbo].[Avaliador_Externo]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Participante] INT NOT NULL, 
    [Area_Atuacao] VARCHAR(50) NOT NULL, 
    [Formacao] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Avaliador_Externo_Participante] FOREIGN KEY ([Id_Participante]) REFERENCES [Participante]([Id])
)
