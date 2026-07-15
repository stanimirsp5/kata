CREATE TABLE dbo.Makes
(
    Id   INT IDENTITY(1,1) NOT NULL,
    Name NVARCHAR(50) NOT NULL,

    CONSTRAINT PK_Makes
        PRIMARY KEY (Id),

    CONSTRAINT UQ_Makes_Name
        UNIQUE (Name)
);
GO


CREATE TABLE dbo.Inventory
(
    Id        INT IDENTITY(1,1) NOT NULL,
    MakeId    INT NOT NULL,
    Color     NVARCHAR(50) NOT NULL,
    PetName   NVARCHAR(50) NOT NULL,
    TimeStamp ROWVERSION NOT NULL,

    CONSTRAINT PK_Inventory
        PRIMARY KEY (Id),

    CONSTRAINT FK_Inventory_Makes
        FOREIGN KEY (MakeId)
        REFERENCES dbo.Makes(Id)
);
GO


CREATE TABLE dbo.Customers
(
    Id        INT IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName  NVARCHAR(50) NOT NULL,

    CONSTRAINT PK_Customers
        PRIMARY KEY (Id)
);
GO


CREATE TABLE dbo.Orders
(
    Id         INT IDENTITY(1,1) NOT NULL,
    CustomerId INT NOT NULL,
    CarId      INT NOT NULL,

    CONSTRAINT PK_Orders
        PRIMARY KEY (Id),

    CONSTRAINT FK_Orders_Customers
        FOREIGN KEY (CustomerId)
        REFERENCES dbo.Customers(Id)
        ON DELETE CASCADE,

    CONSTRAINT FK_Orders_Inventory
        FOREIGN KEY (CarId)
        REFERENCES dbo.Inventory(Id)
);
GO


CREATE TABLE dbo.CreditRisks
(
    Id         INT IDENTITY(1,1) NOT NULL,
    CustomerId INT NOT NULL,
    FirstName  NVARCHAR(50) NOT NULL,
    LastName   NVARCHAR(50) NOT NULL,

    CONSTRAINT PK_CreditRisks
        PRIMARY KEY (Id),

    CONSTRAINT FK_CreditRisks_Customers
        FOREIGN KEY (CustomerId)
        REFERENCES dbo.Customers(Id)
        ON DELETE CASCADE
);
GO

/* Optional indexes for foreign keys */

CREATE INDEX IX_Inventory_MakeId
    ON dbo.Inventory(MakeId);
GO

CREATE INDEX IX_Orders_CustomerId
    ON dbo.Orders(CustomerId);
GO

CREATE INDEX IX_Orders_CarId
    ON dbo.Orders(CarId);
GO

CREATE INDEX IX_Orders_CarId_CustomerId
    ON dbo.Orders(CarId, CustomerId);
GO


CREATE INDEX IX_CreditRisks_CustomerId
    ON dbo.CreditRisks(CustomerId);
GO



/* ============================================================
   SEED DATA
   ============================================================ */

SET IDENTITY_INSERT dbo.Makes ON;

INSERT INTO dbo.Makes (Id, Name)
VALUES
    (1, N'VW'),
    (2, N'Ford'),
    (3, N'Saab'),
    (4, N'Yugo'),
    (5, N'BMW'),
    (6, N'Pinto');

SET IDENTITY_INSERT dbo.Makes OFF;
GO


SET IDENTITY_INSERT dbo.Inventory ON;

INSERT INTO dbo.Inventory (Id, MakeId, Color, PetName)
VALUES
    (1,  1, N'Black',  N'Zippy'),
    (2,  2, N'Rust',   N'Rusty'),
    (3,  3, N'Black',  N'Mel'),
    (4,  4, N'Yellow', N'Clunker'),
    (5,  5, N'Black',  N'Bimmer'),
    (6,  5, N'Green',  N'Hank'),
    (7,  5, N'Pink',   N'Pinky'),
    (8,  6, N'Black',  N'Pete'),
    (9,  4, N'Brown',  N'Brownie'),
    (10, 1, N'Rust',   N'Lemon');

SET IDENTITY_INSERT dbo.Inventory OFF;
GO


SET IDENTITY_INSERT dbo.Customers ON;

INSERT INTO dbo.Customers (Id, FirstName, LastName)
VALUES
    (1, N'Dave',  N'Brenner'),
    (2, N'Matt',  N'Walton'),
    (3, N'Steve', N'Hagen'),
    (4, N'Pat',   N'Walton'),
    (5, N'Bad',   N'Customer');

SET IDENTITY_INSERT dbo.Customers OFF;
GO


SET IDENTITY_INSERT dbo.Orders ON;

INSERT INTO dbo.Orders (Id, CustomerId, CarId)
VALUES
    (1, 1, 5),
    (2, 2, 1),
    (3, 3, 4),
    (4, 4, 7),
    (5, 5, 10);

SET IDENTITY_INSERT dbo.Orders OFF;
GO


SET IDENTITY_INSERT dbo.CreditRisks ON;

INSERT INTO dbo.CreditRisks
    (Id, CustomerId, FirstName, LastName)
VALUES
    (1, 5, N'Bad', N'Customer');

SET IDENTITY_INSERT dbo.CreditRisks OFF;
GO

/* ============================================================
   STORED PROCEDURES
   ============================================================ */

CREATE OR ALTER PROCEDURE dbo.GetPetName
    @carId   INT,
    @petName NVARCHAR(50) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @petName = PetName
    FROM dbo.Inventory
    WHERE Id = @carId;
END;
GO

/* ============================================================
   VIEW
   ============================================================ */

CREATE OR ALTER VIEW dbo.InventoryWithMakes
AS
    SELECT
        i.Id,
        i.MakeId,
        m.Name AS Make,
        i.Color,
        i.PetName,
        i.TimeStamp
    FROM dbo.Inventory AS i
    INNER JOIN dbo.Makes AS m
        ON m.Id = i.MakeId;
GO

/* ============================================================
   VERIFY THE DATABASE
   ============================================================ */

SELECT
    i.Id,
    m.Name AS Make,
    i.Color,
    i.PetName
FROM dbo.Inventory AS i
INNER JOIN dbo.Makes AS m
    ON m.Id = i.MakeId
ORDER BY i.Id;
GO

SELECT *
FROM dbo.Customers
ORDER BY Id;
GO

SELECT *
FROM dbo.Orders
ORDER BY Id;
GO

SELECT *
FROM dbo.CreditRisks
ORDER BY Id;
GO






/* ============================================================
   Delete the database tables
   ============================================================ */


--USE AutoLot;
--GO

--DROP VIEW IF EXISTS dbo.InventoryWithMakes;
--GO

--DROP PROCEDURE IF EXISTS dbo.GetPetName;
--GO

--DROP TABLE IF EXISTS dbo.CreditRisks;
--DROP TABLE IF EXISTS dbo.Orders;
--DROP TABLE IF EXISTS dbo.Inventory;
--DROP TABLE IF EXISTS dbo.Customers;
--DROP TABLE IF EXISTS dbo.Makes;
--GO