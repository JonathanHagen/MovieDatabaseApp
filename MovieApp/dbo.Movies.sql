CREATE TABLE [dbo].[Movies] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (50)  NOT NULL,
    [Director]     NVARCHAR (50)  NOT NULL,
    [DateReleased] DATETIME       NOT NULL,
    [Rating]       TINYINT        NULL,
    [Comment]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

