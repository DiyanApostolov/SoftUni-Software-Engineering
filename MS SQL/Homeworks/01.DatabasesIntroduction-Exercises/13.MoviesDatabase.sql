CREATE TABLE Directors(
Id INT PRIMARY KEY,
DirectorName VARCHAR(60) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Directors([Id], [DirectorName], [Notes]) VALUES 
(1, 'Steven Spillsberg', NULL),
(2, 'Lucke Besson', 'French'),
(3, 'Nikita Mihalkov', 'Russian'),
(4, 'Oodie Allan', 'American'),
(5, 'James Cameron', NULL)

CREATE TABLE Genres(
Id INT PRIMARY KEY,
GenreName VARCHAR(60) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Genres([Id], [GenreName], [Notes]) VALUES 
(1, 'COMEDY', NULL),
(2, 'ACTION', 'COOL'),
(3, 'ROMANTIC', NULL),
(4, 'HORROR', 'SPOOKY'),
(5, 'SCIENCE FICTION', NULL)

CREATE TABLE Categories(
Id INT PRIMARY KEY,
CategoryName VARCHAR(60) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Categories([Id], [CategoryName], [Notes]) VALUES
(1, 'A', 'NO RESTRICTS'),
(2, 'B', '10+ YEARS'),
(3, 'C', '12+ YEARS'),
(4, 'D', '16+ YEARS'),
(5, 'E', '18+ YEARS')

CREATE TABLE Movies(
Id INT PRIMARY KEY,
Title VARCHAR(100) NOT NULL,
CopyrightYear CHAR(4) NOT NULL,
[Length] DECIMAL(15,2),
Rating DECIMAL(15,2),
Notes VARCHAR(MAX)
)

ALTER TABLE Movies
ADD [DirectorId] INT

ALTER TABLE Movies
ADD FOREIGN KEY ([DirectorId]) REFERENCES Directors(Id)

ALTER TABLE Movies
ADD [CategoryId] INT

ALTER TABLE Movies
ADD FOREIGN KEY ([CategoryId]) REFERENCES Categories(Id)

ALTER TABLE Movies
ADD [GenreId] INT

ALTER TABLE Movies
ADD FOREIGN KEY ([GenreId]) REFERENCES Genres(Id)

INSERT INTO Movies([Id], [Title], [CopyrightYear], [Length], [Rating], [Notes], [DirectorId], [GenreId], [CategoryId]) VALUES 
('1', 'FAST AND FURIOUS', '2001', NULL, 10, NULL, 1, 2, 3),
('2', 'HARRY POTTER', '2005', NULL, 8, NULL, 3, 5, 2),
('3', 'JASON BORN', '2016', NULL, 9, NULL, 5, 2, 4),
('4', 'TITANIC', '1997', NULL, 10, NULL, 4, 3, 1),
('5', 'LORD OF THE RINGS', '2012', NULL, 10, NULL, 2, 5, 4)