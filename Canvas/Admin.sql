CREATE TABLE [dbo].[Admin]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Id_Participante] INT NOT NULL, 
    CONSTRAINT [FK_Admin_Participante] FOREIGN KEY ([Id_Participante]) REFERENCES [Participante]([Id])
)
