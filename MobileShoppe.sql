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
    ModelNum VARCHAR(20) UNIQUE,
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
('admin', 'admin', 'Le Van C', '789 Cach Mang Thang 8, Q3', '0933123456', 'Truong cap 1'),
('lamtriphuc00', 'P@ssw0rd', 'Lam Tri Phuc', '123 Le Loi, Q1', '0909123456', 'Ten thu cung'),
('nguyenhongminh00', 'P@ssw0rd', 'Nguyen Hong Minh', '456 Tran Hung Dao, Q5', '0911123456', 'Mon an yeu thich'),
('nguyenhongton00', 'P@ssw0rd', 'Nguyen Hong Ton', '321 Nguyen Thi Minh Khai, Q10', '0944123456', 'So yeu thich'),
('user8386', 'P@ssw0rd', 'May Thi Man', '654 Hai Ba Trung, Q1', '0955123456', 'Dong vat yeu thich');
GO

INSERT INTO tbl_Company VALUES
('1', 'Apple'),
('2', 'Samsung'),
('3', 'Xiaomi'),
('4', 'OPPO'),
('5', 'Nokia');
GO

INSERT INTO tbl_Model VALUES
('1', '1', 'iPhone 13', 2),
('2', '2', 'Galaxy S22', 2),
('3', '3', 'Redmi Note 11', 2),
('4', '4', 'OPPO Reno 8', 1),
('5', '5', 'Nokia G20', 2);
GO

--INSERT INTO tbl_Transaction VALUES
--('1', '1', 2, '2025-04-01', 30000000),
--('2', '2', 3, '2025-04-02', 45000000),
--('3', '3', 5, '2025-04-03', 25000000),
--('4', '4', 4, '2025-04-04', 28000000),
--('5', '5', 1, '2025-04-05', 6000000);
--GO

INSERT INTO tbl_Mobile VALUES
('1', '00000001', 'Not Sold', '2026-04-01', 15000000),
('2', '00000002', 'Not Sold', '2026-04-01', 15000000),
('3', '00000003', 'Not Sold', '2026-04-01', 10000000),
('4', '00000004', 'Not Sold', '2026-04-01', 7000000),
('5', '00000005', 'Not Sold', '2026-04-01', 7000000),
('1', '00000006', 'Not Sold', '2026-04-01', 6000000),
('2', '00000007', 'Not Sold', '2026-04-01', 6000000),
('3', '00000008', 'Not Sold', '2026-04-01', 6000000),
('4', '00000009', 'Not Sold', '2026-04-01', 6000000),
('5', '00000010', 'Not Sold', '2026-04-01', 6000000),
('3', '00000011', 'Not Sold', '2026-04-01', 6000000),
('1', '99999991', 'Sold', '2026-04-01', 6000000),
('2', '99999992', 'Sold', '2026-04-01', 6000000),
('3', '99999993', 'Sold', '2026-04-01', 6000000),
('4', '99999994', 'Sold', '2026-04-01', 6000000),
('5', '99999995', 'Sold', '2026-04-01', 6000000);
GO

INSERT INTO tbl_Customer VALUES
('1', 'Nguyen Thanh', '0981123456', 'thanh@gmail.com', '123 D1, Binh Thanh'),
('2', 'Le Mai', '0982123456', 'mai@gmail.com', '456 D2, Go Vap'),
('3', 'Tran Hieu', '0983123456', 'hieu@gmail.com', '789 D3, Tan Binh'),
('4', 'Pham Linh', '0984123456', 'linh@gmail.com', '321 D4, Q10'),
('5', 'Do Quang', '0985123456', 'quang@gmail.com', '654 D5, Thu Duc');
GO

INSERT INTO tbl_Sales VALUES
('1', '99999991', '2025-04-10', 10000000, '1'),
('2', '99999992', '2025-04-11', 7000000, '2'),
('3', '99999993', '2025-04-12', 6000000, '3'),
('4', '99999994', '2025-04-13', 15000000, '4'),
('5', '99999995', '2025-04-14', 15000000, '5');
GO

 --drop database mobileshoppe;

-- Disable all foreign key constraints
-- EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT ALL";

-- Enable all foreign key constraints
-- EXEC sp_msforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL";

-- PROCEDURES


CREATE PROCEDURE sp_ProcessSale
	@SaleId VARCHAR(20),
	@CusId VARCHAR(20),
    @CustName VARCHAR(20),
    @MobileNumber VARCHAR(20),
    @Email VARCHAR(20),
    @Address VARCHAR(MAX),
    @IMEI VARCHAR(50),
    @Price MONEY,
    @PurchaseDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @CustomerId VARCHAR(20);
        DECLARE @ModelId VARCHAR(20);

        -- 1. Kiểm tra khách hàng
        SELECT @CustomerId = CusId FROM tbl_Customer WHERE MobileNumber = @MobileNumber;

        IF @CustomerId IS NULL
        BEGIN
            -- Dùng @CusId từ phía C# truyền vào
            INSERT INTO tbl_Customer (CusId, CustName, MobileNumber, EmailId, Address)
            VALUES (@CusId, @CustName, @MobileNumber, @Email, @Address);
        END
        ELSE
        BEGIN
            SET @CusId = @CustomerId;
        END

        -- 2. Lấy ModelId từ IMEI
        SELECT @ModelId = ModelId FROM tbl_Mobile WHERE IMEINO = @IMEI;

        -- 3. Ghi vào bảng Sales
        INSERT INTO tbl_Sales (SlsId, IMEINO, PurchageDate, Price, CusId)
        VALUES (@SaleId, @IMEI, @PurchaseDate, @Price, @CusId);

        -- 4. Đánh dấu máy đã bán
        UPDATE tbl_Mobile SET Status = 'Sold' WHERE IMEINO = @IMEI;

        -- 5. Trừ số lượng tồn kho
        UPDATE tbl_Model SET AvailableQty = AvailableQty - 1 WHERE ModelId = @ModelId;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END;
GO
