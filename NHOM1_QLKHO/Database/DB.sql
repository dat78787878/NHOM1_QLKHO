CREATE DATABASE QLKHO


CREATE TABLE QLKHO.dbo.Employee (
  EmployeeCode varchar(10) NOT NULL,
  EmployeeName nvarchar(50) NULL,
  DateOfBirth date NULL,
  PhoneNumber char(10) NULL,
  CONSTRAINT PK_NhanVien_EmployeeCode PRIMARY KEY CLUSTERED (EmployeeCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.Producer  (
  ProducerCode varchar(10) NOT NULL,
  ProducerName nvarchar(50) NULL,
  Address nvarchar(50) NULL,
  PhoneNumber char(10) NULL,
  CONSTRAINT PK_NhaSanXuat_ProducerCode PRIMARY KEY CLUSTERED (ProducerCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.EnterCoupon (
  EnterCouponCode varchar(10) NOT NULL,
  CommodityCode varchar(10) NULL,
  EmployeeCode varchar(10) NULL,
  DateOfImport date NULL,
  NumberOfImport int NULL,
  CONSTRAINT PK_PhieuNhap_EnterCouponCode PRIMARY KEY CLUSTERED (EnterCouponCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.Bill (
  BillCode varchar(10) NOT NULL,
  CommodityCode varchar(10) NULL,
  EmployeeCode varchar(10) NULL,
  DateOfExport date NULL,
  NumberOfExport int NULL,
  CONSTRAINT PK_PhieuXuat_BillCode PRIMARY KEY CLUSTERED (BillCode)
)
ON [PRIMARY]
GO

CREATE TABLE QLKHO.dbo.Commodity (
  CommodityCode varchar(10) NOT NULL,
  CommodityName nvarchar(50) NULL,
  DateOfManufacture date NULL/,
  ExpiryDate  date NULL,
  ProducerCode varchar(10) NULL,
  Amount int NULL,
  CONSTRAINT PK_HangHoa_CommodityCode PRIMARY KEY CLUSTERED (CommodityCode)
)
ON [PRIMARY]
GO