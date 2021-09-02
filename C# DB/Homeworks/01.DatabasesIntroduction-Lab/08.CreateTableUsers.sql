CREATE TABLE Users (
	Id BIGINT PRIMARY KEY IDENTITY,
	USername VARCHAR (30) UNIQUE NOT NULL,
	[Password] VARCHAR (26) NOT NULL,
	ProfilePicture VARBINARY (MAX),
	CHECK(DATALENGTH(ProfilePicture) <= 921600),
	LastLoginTime DATETIME2,
	IsDeleted BIT
)

INSERT INTO Users (USername, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES ('Gogich', 'Goshko123', 3, '2021-05-18', 0),
		('Sodar', 'Marti13', 7, '2021-03-15', 0),
		('Jivka', 'OtPochivka', 15, '2021-04-25', 0),
		('Peter', 'Georgiev81', 9, '2021-02-12', 0),
		('DartVader', 'Imperia', 34, '2021-01-09', 0)