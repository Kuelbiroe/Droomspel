﻿CREATE TABLE [dbo].[Music]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY NONCLUSTERED,
	[GamePointsMusic] INT NOT NULL,
	[GameTypeMusic] NVARCHAR(30) NOT NULL,
	[DifficultyUnlocked] NVARCHAR(30) NOT NULL,
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [FK_Music_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)