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
