CREATE TABLE [dbo].[Projeto]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Status] VARCHAR(20) NOT NULL, 
    [Resposta_1] VARCHAR(2000) NULL, 
    [Resposta_2] VARCHAR(2000) NULL, 
    [Resposta_3] VARCHAR(2000) NULL, 
    [Resposta_4] VARCHAR(2000) NULL, 
    [Resposta_5] VARCHAR(2000) NULL, 
    [Resposta_6] VARCHAR(2000) NULL, 
    [Resposta_7] VARCHAR(2000) NULL, 
    [Resposta_8] VARCHAR(2000) NULL, 
    [Resposta_9] VARCHAR(2000) NULL, 
    [Nome] VARCHAR(50) NOT NULL
)
