CREATE TABLE [dbo].[Avaliacao]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Avaliador_Projeto] INT NOT NULL, 
    [Nota_Quadro_1] INT NULL, 
    [Nota_Quadro_2] INT NULL, 
    [Nota_Quadro_3] INT NULL, 
    [Nota_Quadro_4] INT NULL, 
    [Nota_Quadro_5] INT NULL, 
    [Nota_Quadro_6] INT NULL, 
    [Nota_Quadro_7] INT NULL, 
    [Nota_Quadro_8] INT NULL, 
    [Nota_Quadro_9] INT NULL, 
    CONSTRAINT [FK_Avaliacao_Avaliador_Projeto] FOREIGN KEY ([Id_Avaliador_Projeto]) REFERENCES [Avaliador_Projeto]([Id])
)
