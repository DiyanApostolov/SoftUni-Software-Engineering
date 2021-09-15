CREATE TABLE [Users](
	[Id] DECIMAL PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	[ProfilePicture] VARBINARY(MAX),
	CHECK (DATALENGTH([ProfilePicture]) <= 900000),
	[LastLoginTime] DATETIME2,
	[IsDeleted] BIT NOT NULL
)

INSERT INTO Users([Username], [Password], [LastLoginTime], [IsDeleted]) VALUES 
('Pesho','123456','1989-05-20',0),
('Gosho','123456','1969-02-21',1),
('Dancho','123456','1999-05-16',0),
('Dimitrichko','123456','1976-02-09',1),
('Didko','123456','1999-05-05',0)