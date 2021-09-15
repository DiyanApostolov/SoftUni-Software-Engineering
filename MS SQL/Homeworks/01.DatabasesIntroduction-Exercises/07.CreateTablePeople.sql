CREATE TABLE [People](
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Username] NVARCHAR(200) UNIQUE NOT NULL,
	[Picture] VARBINARY(MAX),
	CHECK (DATALENGTH([Picture]) <= 2000*1024),
	[Height] FLOAT(2),
	[Weight] FLOAT(2),
	[Gender] CHAR(1) CONSTRAINT One_letter CHECK([Gender] in ('f','m')) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[Biography] NVARCHAR(MAX)
)


INSERT INTO People ([Username], Picture, Height, [Weight], Gender, Birthdate, Biography)
VALUES	    ('Kiro Kirkov', 2, 1.85, 35.5, 'm', '1989-05-20', 'Zdr'),
	    ('Ivan Ivanov', 1, NULL, 40.0, 'm', '1969-02-21', 'Zdrrr'),
	    ('Pesho Peshov', 2, 2.10, NULL, 'm', '1999-05-16', NULL),
	    ('Stamat Stamatov', 1, 1.93, 81.0, 'm', '1976-02-09', 'Zdrastiii'),
	    ('Vanko Vankov', 1, 1.71, 75.8, 'm', '1999-05-05', 'Opa')