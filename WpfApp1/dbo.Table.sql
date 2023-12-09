CREATE TABLE [dbo].[Volume]
(
	[ShapesId] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50),
	[Length] FLOAT,
	[Width] FLOAT,
	[Height] FLOAT
)
