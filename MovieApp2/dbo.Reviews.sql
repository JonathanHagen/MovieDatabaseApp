CREATE TABLE [dbo].[Reviews]
(
	[RatingId] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [MovieId] INT NOT NULL, 
    [NumberOfStars] TINYINT NOT NULL, 
    [Comments] NVARCHAR(100) NOT NULL
)
