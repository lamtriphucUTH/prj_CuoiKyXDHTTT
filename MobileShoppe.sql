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

-- Disable all foreign key constraints
EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT ALL";

-- Enable all foreign key constraints
EXEC sp_msforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL";

INSERT INTO tbl_User VALUES
('user1', '1', 'Nguyen Van A', '123 Le Loi, Q1', '0909123456', 'Tên thú cưng'),
('user2', '1', 'Tran Thi B', '456 Tran Hung Dao, Q5', '0911123456', 'Món ăn yêu thích'),
('admin', '1', 'Le Van C', '789 Cach Mang Thang 8, Q3', '0933123456', 'Trường cấp 1'),
('user3', '1', 'Pham Duy D', '321 Nguyen Thi Minh Khai, Q10', '0944123456', 'Số yêu thích'),
('user4', '1', 'Doan Thi E', '654 Hai Ba Trung, Q1', '0955123456', 'Động vật yêu thích');
GO

INSERT INTO tbl_Company VALUES
('C001', 'Apple'),
('C002', 'Samsung'),
('C003', 'Xiaomi'),
('C004', 'OPPO'),
('C005', 'Nokia');
GO

INSERT INTO tbl_Model VALUES
('M001', 'C001', 'iPhone 13', 10),
('M002', 'C002', 'Galaxy S22', 15),
('M003', 'C003', 'Redmi Note 11', 20),
('M004', 'C004', 'OPPO Reno 8', 12),
('M005', 'C005', 'Nokia G20', 8);
GO

INSERT INTO tbl_Transaction VALUES
('T001', 'M001', 2, '2025-04-01', 30000000),
('T002', 'M002', 3, '2025-04-02', 45000000),
('T003', 'M003', 5, '2025-04-03', 25000000),
('T004', 'M004', 4, '2025-04-04', 28000000),
('T005', 'M005', 1, '2025-04-05', 6000000);
GO

INSERT INTO tbl_Mobile VALUES
('M001', 'IMEI0001', 'In Stock', '2026-04-01', 15000000),
('M002', 'IMEI0002', 'In Stock', '2026-04-01', 15000000),
('M003', 'IMEI0003', 'Sold', '2026-04-01', 10000000),
('M004', 'IMEI0004', 'Sold', '2026-04-01', 7000000),
('M005', 'IMEI0005', 'In Stock', '2026-04-01', 6000000);
GO

INSERT INTO tbl_Customer VALUES
('CU001', 'Nguyen Thanh', '0981123456', 'thanh@example.com', '123 D1, Binh Thanh'),
('CU002', 'Le Mai', '0982123456', 'mai@example.com', '456 D2, Go Vap'),
('CU003', 'Tran Hieu', '0983123456', 'hieu@example.com', '789 D3, Tan Binh'),
('CU004', 'Pham Linh', '0984123456', 'linh@example.com', '321 D4, Q10'),
('CU005', 'Do Quang', '0985123456', 'quang@example.com', '654 D5, Thu Duc');
GO

INSERT INTO tbl_Sales VALUES
('S001', 'IMEI0003', '2025-04-10', 10000000, 'CU001'),
('S002', 'IMEI0004', '2025-04-11', 7000000, 'CU002'),
('S003', 'IMEI0005', '2025-04-12', 6000000, 'CU003'),
('S004', 'IMEI0001', '2025-04-13', 15000000, 'CU004'),
('S005', 'IMEI0002', '2025-04-14', 15000000, 'CU005');
GO

