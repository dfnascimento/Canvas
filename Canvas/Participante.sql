CREATE TABLE [dbo].[Participante]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Email] VARCHAR(50) NOT NULL, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Senha] VARCHAR(50) NOT NULL, 
    [Status] VARCHAR(10) NOT NULL
)
