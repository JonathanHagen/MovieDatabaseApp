CREATE TABLE [dbo].[Movies]
(
	[MovieId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(100) NOT NULL, 
    [Director] NVARCHAR(100) NOT NULL, 
    [DateReleased] DATETIME NOT NULL
)
