CREATE DATABASE QLKHO
go

CREATE TABLE QLKHO.dbo.Employee (
  EmployeeCode int IDENTITY,
  EmployeeName nvarchar(50) NULL,
  DateOfBirth date NULL,
  PhoneNumber char(10) NULL,
  CONSTRAINT PK_NhanVien_EmployeeCode PRIMARY KEY CLUSTERED (EmployeeCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.Producer (
  ProducerCode int IDENTITY,
  ProducerName nvarchar(50) NULL,
  Address nvarchar(50) NULL,
  PhoneNumber char(10) NULL,
  CONSTRAINT PK_NhaSanXuat_ProducerCode PRIMARY KEY CLUSTERED (ProducerCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.EnterCoupon (
  EnterCouponCode int IDENTITY,
  CommodityCode int NULL,
  EmployeeCode int NULL,
  DateOfImport date NULL,
  NumberOfImport int NULL,
  CONSTRAINT PK_PhieuNhap_EnterCouponCode PRIMARY KEY CLUSTERED (EnterCouponCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.Commodity (
  CommodityCode int IDENTITY,
  CommodityName nvarchar(50) NULL,
  DateOfManufacture date NULL,
  ExpiryDate date NULL,
  ProducerCode int NULL,
  Amount int NULL,
  CONSTRAINT PK_HangHoa_CommodityCode PRIMARY KEY CLUSTERED (CommodityCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.Bill (
  BillCode int IDENTITY,
  CommodityCode int NULL,
  EmployeeCode int NULL,
  DateOfExport date NULL,
  NumberOfExport int NULL,
  CONSTRAINT PK_PhieuXuat_BillCode PRIMARY KEY CLUSTERED (BillCode)
)
ON [PRIMARY]
GO

ALTER TABLE QLKHO.dbo.EnterCoupon
  ADD CONSTRAINT FK_EnterCoupon_Commodity FOREIGN KEY (CommodityCode) REFERENCES dbo.Commodity (CommodityCode)
GO

ALTER TABLE QLKHO.dbo.EnterCoupon
  ADD CONSTRAINT FK_EnterCoupon_Employee FOREIGN KEY (EmployeeCode) REFERENCES dbo.Employee (EmployeeCode)
GO



ALTER TABLE QLKHO.dbo.Bill
  ADD CONSTRAINT FK_Bill_Commodity FOREIGN KEY (CommodityCode) REFERENCES dbo.Commodity (CommodityCode)
GO

ALTER TABLE QLKHO.dbo.Bill
  ADD CONSTRAINT FK_Bill_Employee FOREIGN KEY (EmployeeCode) REFERENCES dbo.Employee (EmployeeCode)
GO

ALTER TABLE QLKHO.dbo.Commodity
  ADD CONSTRAINT FK_Commodity_Producer FOREIGN KEY (ProducerCode) REFERENCES dbo.Producer (ProducerCode)
GO

-----------------------Long quản lý phiếu nhập------------------------------
CREATE PROCEDURE EnterCoupon_Search
@searchValue NVARCHAR(200)  
as
Begin  
  SELECT *
  FROM EnterCoupon
  WHERE EnterCouponCode LIKE N'%' + @searchValue + '%'
    OR CommodityCode LIKE N'%' + @searchValue + '%'
    OR EmployeeCode LIKE N'%' + @searchValue + '%'
    OR DateOfImport LIKE N'%' + @searchValue + '%'
    OR NumberOfImport LIKE N'%' + @searchValue + '%'
END
GO

CREATE PROCEDURE EnterCoupon_GetAll
AS
BEGIN
  SELECT *
  FROM EnterCoupon
END
GO

CREATE PROCEDURE EnterCoupon_Delete
  @EnterCouponCode INT
AS
BEGIN
  DELETE EnterCoupon
  WHERE EnterCouponCode = @EnterCouponCode
END
GO

CREATE PROCEDURE EnterCoupon_Insert
  @CommodityCode INT,
  @EmployeeCode INT,
  @DateOfImport date,
  @NumberOfImport INT
AS
BEGIN
  INSERT INTO EnterCoupon
    (CommodityCode, EmployeeCode, DateOfImport, NumberOfImport)
  VALUES(@CommodityCode, @EmployeeCode, @DateOfImport, @NumberOfImport)
END
GO

CREATE PROCEDURE EnterCoupon_Update
  @EnterCouponCode INT,
  @CommodityCode INT,
  @EmployeeCode INT,
  @DateOfImport date,
  @NumberOfImport INT
AS
BEGIN
  UPDATE EnterCoupon
  SET CommodityCode  = @CommodityCode,
  EmployeeCode = @EmployeeCode,
  DateOfImport = @DateOfImport,
  NumberOfImport = @NumberOfImport
  WHERE EnterCouponCode = @EnterCouponCode
END
GO

CREATE PROCEDURE Employee_GetAll
AS
BEGIN
  SELECT *
  FROM Employee
END
GO

CREATE PROCEDURE Commodity_GetAll
AS
BEGIN
  SELECT *
  FROM Commodity
END
GO

