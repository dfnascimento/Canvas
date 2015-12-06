CREATE TABLE [dbo].[Peso]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Projeto] INT NOT NULL, 
    [Peso_Quadro_1] INT NULL, 
    [Peso_Quadro_2] INT NULL, 
    [Peso_Quadro_3] INT NULL, 
    [Peso_Quadro_4] INT NULL, 
    [Peso_Quadro_5] INT NULL, 
    [Peso_Quadro_6] INT NULL, 
    [Peso_Quadro_7] INT NULL, 
    [Peso_Quadro_8] INT NULL, 
    [Peso_Quadro_9] INT NULL, 
    CONSTRAINT [FK_Peso_Projeto] FOREIGN KEY ([Id_Projeto]) REFERENCES [Projeto]([Id])
)
