CREATE DATABASE CarRental

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) UNIQUE NOT NULL, 
	DailyRate DECIMAL(3, 1) NOT NULL, 
	WeeklyRate DECIMAL(3, 1) NOT NULL, 
	MonthlyRate DECIMAL(3, 1) NOT NULL, 
	WeekendRate DECIMAL(3, 1) NOT NULL
)

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY, 
	PlateNumber NVARCHAR(10) UNIQUE NOT NULL, 
	Manufacturer NVARCHAR(20) NOT NULL, 
	Model NVARCHAR(20) NOT NULL, 
	CarYear DATE NOT NULL, 
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id), 
	Doors INT NOT NULL, 
	Picture VARBINARY, 
	Condition NVARCHAR(200), 
	Available BIT NOT NULL
)

CREATE TABLE Employees (
	Id INT PRIMARY KEY IDENTITY, 
	FirstName NVARCHAR(30) NOT NULL, 
	LastName NVARCHAR(30) NOT NULL, 
	Title NVARCHAR(30), 
	Notes NVARCHAR(MAX)
)

CREATE TABLE Customers  (
	Id INT PRIMARY KEY IDENTITY, 
	DriverLicenceNumber INT UNIQUE NOT NULL, 
	FullName NVARCHAR(60) NOT NULL, 
	[Address] NVARCHAR(100), 
	City NVARCHAR(20), 
	ZIPCode INT, 
	Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders   (
	Id INT PRIMARY KEY IDENTITY, 
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id), 
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id), 
	CarId INT FOREIGN KEY REFERENCES Cars(Id), 
	TankLevel INT NOT NULL, 
	KilometrageStart INT NOT NULL, 
	KilometrageEnd INT NOT NULL, 
	TotalKilometrage INT NOT NULL, 
	StartDate DATETIME2, 
	EndDate DATETIME2, 
	TotalDays INT NOT NULL, 
	RateApplied DECIMAL(2, 1), 
	TaxRate DECIMAL(2, 1), 
	OrderStatus NVARCHAR(50), 
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) 
VALUES		
	('Category1', 5.4, 6.2, 7.2, 10.0),
	('Category2', 4.4, 8.2, 9.2, 12.0),
	('Category3', 2.3, 4.2, 8.2, 5.9)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) 
VALUES
	('1234', 'Mercedes', 'SL500', '2010', 1, 2, NULL, NULL, 1),
	('1442', 'Audi', 'A7', '2018', 2, 5, NULL, NULL, 1),
	('1312', 'BMW', 'E50', '2012', 3, 4, NULL, NULL, 0)

INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES 
	('Dimitrichko', 'Kamenov', NULL, NULL),
	('Pesho', 'Peshev', NULL, NULL),
	('Gosho', 'Kazakov', NULL, NULL)

INSERT INTO Customers (DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes)
VALUES 
	('12345', 'Diyan', NULL, NULL, NULL, NULL),
	('123456', 'Tacho', NULL, NULL, NULL, NULL),
	('1234567', 'Martin', NULL, NULL, NULL, NULL)

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, 
			TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
VALUES
	(1, 1, 1, 50, 0, 320, 198000, '2010-05-10', '2010-05-15', 5, NULL, NULL, NULL, NULL),
	(2, 2, 2, 50, 0, 260, 35682, '2012-11-15', '2012-11-21', 6, NULL, NULL, NULL, NULL),
	(3, 3, 3, 50, 0, 220, 67820, '2014-08-31', '2014-09-01', 1, NULL, NULL, NULL, NULL)