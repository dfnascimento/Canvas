﻿CREATE TABLE [dbo].[Comentario]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Aluno_Projeto] INT NOT NULL, 
    [Quadro_1] VARCHAR(200) NULL, 
    [Quadro_2] VARCHAR(200) NULL, 
    [Quadro_3] VARCHAR(200) NULL, 
    [Quadro_4] VARCHAR(200) NULL, 
    [Quadro_5] VARCHAR(200) NULL, 
    [Quadro_6] VARCHAR(200) NULL, 
    [Quadro_7] VARCHAR(200) NULL, 
    [Quadro_8] VARCHAR(200) NULL, 
    [Quadro_9] VARCHAR(200) NULL, 
    CONSTRAINT [FK_Comentario_Aluno_Projeto] FOREIGN KEY ([Id_Aluno_Projeto]) REFERENCES [Aluno_Projeto]([Id])
)
