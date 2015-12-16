CREATE TABLE [dbo].[Comentario]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Orientador_Projeto] INT NOT NULL, 
    [Quadro_1] VARCHAR(2000) NULL, 
    [Quadro_2] VARCHAR(2000) NULL, 
    [Quadro_3] VARCHAR(2000) NULL, 
    [Quadro_4] VARCHAR(2000) NULL, 
    [Quadro_5] VARCHAR(2000) NULL, 
    [Quadro_6] VARCHAR(2000) NULL, 
    [Quadro_7] VARCHAR(2000) NULL, 
    [Quadro_8] VARCHAR(2000) NULL, 
    [Quadro_9] VARCHAR(2000) NULL, 
    CONSTRAINT [FK_Comentario_Orientador_Projeto] FOREIGN KEY ([Id_Orientador_Projeto]) REFERENCES [Orientador_Projeto]([Id])
)
