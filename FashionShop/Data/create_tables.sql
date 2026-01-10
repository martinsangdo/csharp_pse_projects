USE malefashion;

-- SELECT name FROM sys.objects WHERE name = 'Products';

-- CREATE TABLE Products (
--     ProductID INT IDENTITY(1,1) PRIMARY KEY,
--     Name NVARCHAR(255),
--     Description TEXT,
--     BrandID TINYINT,
--     CategoryID TINYINT,
--     Size NVARCHAR(5),
--     Color NVARCHAR(10),
--     Quantity TINYINT,
--     Sku NVARCHAR(20),
--     Star FLOAT,
--     Price FLOAT,
--     DiscountPrice FLOAT,

--     IsActive BIT DEFAULT 1,
--     CreatedAt DATETIME2 DEFAULT SYSDATETIME(),
--     UpdatedAt DATETIME2 DEFAULT SYSDATETIME()
-- );

-- CREATE TABLE ProductImages (
--     ImageID INT IDENTITY(1,1) PRIMARY KEY,
--     ProductID INT,
--     Url NVARCHAR(500)
-- );

-- CREATE TABLE Brands (
--     BrandID INT IDENTITY(1,1) PRIMARY KEY,
--     BrandName NVARCHAR(150)
-- );

-- CREATE TABLE Categories (
--     CategoryID INT IDENTITY(1,1) PRIMARY KEY,
--     ParentID INT NULL,
--     CategoryName NVARCHAR(150)
-- );

-- CREATE TABLE AppUsers (
--     UserID INT IDENTITY(1,1) PRIMARY KEY,
--     Email NVARCHAR(255) UNIQUE NOT NULL,
--     PasswordHash NVARCHAR(500),
--     FullName NVARCHAR(150),
--     Role NVARCHAR(50) DEFAULT 'Customer',
--     CreatedAt DATETIME2 DEFAULT SYSDATETIME(),
--     IsActive BIT DEFAULT 1
-- );

