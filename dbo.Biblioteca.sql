CREATE TABLE [dbo].[Biblioteca]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [titulo] NVARCHAR(50) NOT NULL, 
    [autor] NVARCHAR(50) NOT NULL, 
    [publicacion] DATE NULL
)
