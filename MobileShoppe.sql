﻿CREATE DATABASE MobileShoppe;
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


INSERT INTO tbl_User VALUES
('admin', '1', 'Le Van C', '789 Cach Mang Thang 8, Q3', '0933123456', 'Trường cấp 1'),
('user1', '1', 'Nguyen Van A', '123 Le Loi, Q1', '0909123456', 'Tên thú cưng'),
('user2', '1', 'Tran Thi B', '456 Tran Hung Dao, Q5', '0911123456', 'Món ăn yêu thích'),
('user3', '1', 'Pham Duy D', '321 Nguyen Thi Minh Khai, Q10', '0944123456', 'Số yêu thích'),
('user4', '1', 'Doan Thi E', '654 Hai Ba Trung, Q1', '0955123456', 'Động vật yêu thích');
GO

INSERT INTO tbl_Company VALUES
('1', 'Apple'),
('2', 'Samsung'),
('3', 'Xiaomi'),
('4', 'OPPO'),
('5', 'Nokia');
GO

INSERT INTO tbl_Model VALUES
('1', '1', 'iPhone 13', 10),
('2', '2', 'Galaxy S22', 15),
('3', '3', 'Redmi Note 11', 20),
('4', '4', 'OPPO Reno 8', 12),
('5', '5', 'Nokia G20', 8);
GO

INSERT INTO tbl_Transaction VALUES
('1', '1', 2, '2025-04-01', 30000000),
('2', '2', 3, '2025-04-02', 45000000),
('3', '3', 5, '2025-04-03', 25000000),
('4', '4', 4, '2025-04-04', 28000000),
('5', '5', 1, '2025-04-05', 6000000);
GO

INSERT INTO tbl_Mobile VALUES
('1', 'IMEI0001', 'In Stock', '2026-04-01', 15000000),
('2', 'IMEI0002', 'In Stock', '2026-04-01', 15000000),
('3', 'IMEI0003', 'Sold', '2026-04-01', 10000000),
('4', 'IMEI0004', 'Sold', '2026-04-01', 7000000),
('5', 'IMEI0005', 'In Stock', '2026-04-01', 6000000);
GO

INSERT INTO tbl_Customer VALUES
('1', 'Nguyen Thanh', '0981123456', 'thanh@example.com', '123 D1, Binh Thanh'),
('2', 'Le Mai', '0982123456', 'mai@example.com', '456 D2, Go Vap'),
('3', 'Tran Hieu', '0983123456', 'hieu@example.com', '789 D3, Tan Binh'),
('4', 'Pham Linh', '0984123456', 'linh@example.com', '321 D4, Q10'),
('5', 'Do Quang', '0985123456', 'quang@example.com', '654 D5, Thu Duc');
GO

INSERT INTO tbl_Sales VALUES
('1', 'IMEI0003', '2025-04-10', 10000000, '1'),
('2', 'IMEI0004', '2025-04-11', 7000000, '2'),
('3', 'IMEI0005', '2025-04-12', 6000000, '3'),
('4', 'IMEI0001', '2025-04-13', 15000000, '4'),
('5', 'IMEI0002', '2025-04-14', 15000000, '5');
GO

 --drop database mobileshoppe;

-- Disable all foreign key constraints
-- EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT ALL";

-- Enable all foreign key constraints
-- EXEC sp_msforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL";

-- PROCEDURES
CREATE PROCEDURE sp_Login
    @UserName VARCHAR(20),
    @PWD VARCHAR(20)
AS
BEGIN
    SELECT * FROM tbl_User 
    WHERE UserName = @UserName AND PWD = @PWD
END
GO

CREATE PROCEDURE sp_AddCompany
    @ComId VARCHAR(20),
    @CName VARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_Company (ComId, CName)
    VALUES (@ComId, @CName)
END
GO

CREATE PROCEDURE sp_AddModel
    @ModelId VARCHAR(20),
    @ComId VARCHAR(20),
    @ModelNum VARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_Model (ModelId, ComId, ModelNum)
    VALUES (@ModelId, @ComId, @ModelNum)
END
GO

CREATE PROCEDURE sp_AddMobile
    @ModelId VARCHAR(20),
    @IMEINO VARCHAR(50),
    @Status VARCHAR(20),
    @Warranty DATE,
    @Price MONEY
AS
BEGIN
    INSERT INTO tbl_Mobile (ModelId, IMEINO, Status, Warranty, Price)
    VALUES (@ModelId, @IMEINO, @Status, @Warranty, @Price)
END
GO

CREATE PROCEDURE sp_UpdateStock
    @ModelId VARCHAR(20),
    @Quantity INT
AS
BEGIN
    UPDATE tbl_Model
    SET AvailableQty = AvailableQty + @Quantity
    WHERE ModelId = @ModelId
END
GO

CREATE PROCEDURE sp_SalesReport_ByDate
    @Date DATE
AS
BEGIN
    SELECT * FROM tbl_Sales
    WHERE CONVERT(DATE, PurchageDate) = @Date
END
GO

CREATE PROCEDURE sp_SalesReport_DateToDate
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SELECT * FROM tbl_Sales
    WHERE PurchageDate BETWEEN @FromDate AND @ToDate
END
GO

CREATE PROCEDURE sp_AddUser
    @UserName VARCHAR(20),
    @PWD VARCHAR(20),
    @EmployeeName VARCHAR(20),
    @Address VARCHAR(MAX),
    @MobileNumber VARCHAR(20),
    @Hint VARCHAR(50)
AS
BEGIN
    INSERT INTO tbl_User (UserName, PWD, EmployeeName, Address, MobileNumber, Hint)
    VALUES (@UserName, @PWD, @EmployeeName, @Address, @MobileNumber, @Hint)
END
GO

CREATE PROCEDURE sp_AddCustomer
    @CusId VARCHAR(20),
    @CustName VARCHAR(20),
    @MobileNumber VARCHAR(20),
    @EmailId VARCHAR(20),
    @Address VARCHAR(MAX)
AS
BEGIN
    INSERT INTO tbl_Customer (CusId, CustName, MobileNumber, EmailId, Address)
    VALUES (@CusId, @CustName, @MobileNumber, @EmailId, @Address)
END
GO

CREATE PROCEDURE sp_SellMobile
    @SlsId VARCHAR(20),
    @IMEINO VARCHAR(50),
    @PurchageDate DATE,
    @Price MONEY,
    @CusId VARCHAR(20)
AS
BEGIN
    INSERT INTO tbl_Sales (SlsId, IMEINO, PurchageDate, Price, CusId)
    VALUES (@SlsId, @IMEINO, @PurchageDate, @Price, @CusId)

    -- Cập nhật trạng thái máy đã bán
    UPDATE tbl_Mobile
    SET Status = 'Sold'
    WHERE IMEINO = @IMEINO
END
GO

CREATE PROCEDURE sp_ViewStock
AS
BEGIN
    SELECT m.ModelId, m.ModelNum, c.CName, m.AvailableQty
    FROM tbl_Model m
    INNER JOIN tbl_Company c ON m.ComId = c.ComId
END
GO

CREATE PROCEDURE sp_SearchCustomerByIMEI
    @IMEINO VARCHAR(50)
AS
BEGIN
    SELECT c.*
    FROM tbl_Customer c
    INNER JOIN tbl_Sales s ON c.CusId = s.CusId
    WHERE s.IMEINO = @IMEINO
END
GO
