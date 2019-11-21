﻿CREATE TABLE [dbo].[Message]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY NONCLUSTERED,
	[UserId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [FK_Message_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)