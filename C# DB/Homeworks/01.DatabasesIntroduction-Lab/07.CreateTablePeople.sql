CREATE TABLE People (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX),
	CHECK(DATALENGTH(Picture) <= 2097153),
	Height DECIMAL(3, 2),
	[Weight] DECIMAL(5, 2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People ([Name], Picture, Height, [Weight], Gender, Birthdate, Biography)
VALUES	('Pesho Peshov', 2, 1.73, 65.5, 'm', '1985-12-03', 'Zdr'),
		('Angel Angelov', 1, 1.65, 58.3, 'm', '1987-11-05', 'Zdrasti'),
		('Sir Stanley Royce', 2, 1.85, 82.2, 'm', '1975-05-20', 'Suh Suh'),
		('Slavi Trifonov', 2, 2.05, 95.1, 'm', '1975-10-18', '7/8'),
		('Maya Manolova', 1, NULL, 58.5, 'f', '1978-05-03', 'Mutri')