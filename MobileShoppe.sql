CREATE DATABASE MobileShoppe;
GO
USE MobileShoppe;
GO

-- tbl_User
CREATE TABLE tbl_User (
    UserName VARCHAR(20) PRIMARY KEY,
    PWD VARCHAR(20), -- Password
    EmployeeName VARCHAR(20),
    Address VARCHAR(MAX),
    MobileNumber VARCHAR(20),
    Hint VARCHAR(50)
);

-- tbl_Company
CREATE TABLE tbl_Company (
    ComId VARCHAR(20) PRIMARY KEY,
    CName VARCHAR(20)
);

-- tbl_Model
CREATE TABLE tbl_Model (
    ModelId VARCHAR(20) PRIMARY KEY,
    ComId VARCHAR(20),
    ModelNum VARCHAR(20),
    AvailableQty INT,
    FOREIGN KEY (ComId) REFERENCES tbl_Company(ComId)
);

-- tbl_Transaction
CREATE TABLE tbl_Transaction (
    TransId VARCHAR(20) PRIMARY KEY,
    ModelId VARCHAR(20),
    Quantity INT,
    Date DATE,
    Amount MONEY,
    FOREIGN KEY (ModelId) REFERENCES tbl_Model(ModelId)
);

-- tbl_Mobile
CREATE TABLE tbl_Mobile (
    ModelId VARCHAR(20),
    IMEINO VARCHAR(50) PRIMARY KEY,
    Status VARCHAR(20),
    Warranty DATE,
    Price MONEY,
    FOREIGN KEY (ModelId) REFERENCES tbl_Model(ModelId)
);

-- tbl_Customer
CREATE TABLE tbl_Customer (
    CusId VARCHAR(20) PRIMARY KEY,
    CustName VARCHAR(20),
    MobileNumber VARCHAR(20),
    EmailId VARCHAR(20),
    Address VARCHAR(MAX)
);

-- tbl_Sales
CREATE TABLE tbl_Sales (
    SlsId VARCHAR(20) PRIMARY KEY,
    IMEINO VARCHAR(50),
    PurchageDate DATE,
    Price MONEY,
    CusId VARCHAR(20),
    FOREIGN KEY (IMEINO) REFERENCES tbl_Mobile(IMEINO),
    FOREIGN KEY (CusId) REFERENCES tbl_Customer(CusId)
);

-- Disable all foreign key constraints
EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT ALL";

-- Enable all foreign key constraints
EXEC sp_msforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL";
