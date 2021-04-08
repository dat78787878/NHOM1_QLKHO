

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


CREATE PROCEDURE Commodity_GetAll
AS
BEGIN
  SELECT *
  FROM Commodity
END
GO

------------Procedure Employee 
CREATE PROCEDURE Employee_GetAll
AS
BEGIN
  SELECT *
  FROM Employee
END
GO

CREATE PROCEDURE Employee_Insert
  @fullName NVARCHAR(50),
  @dateOfBirth date,
  @phoneNumber varchar(10)
AS
BEGIN
  INSERT INTO Employee
    (EmployeeName, DateOfBirth, PhoneNumber)
  VALUES(@fullName, @dateOfBirth, @phoneNumber)
END
GO



CREATE PROCEDURE Employee_Delete
  @employeeCode INT
AS
BEGIN
  DELETE Employee
  WHERE EmployeeCode = @employeeCode
END
GO

CREATE PROCEDURE Employee_Update
  @employeeCode INT,
  @fullName NVARCHAR(50),
  @dateOfBirth date,
  @phoneNumber varchar(10)
AS
BEGIN
  UPDATE Employee
  SET EmployeeName  = @fullName,
  DateOfBirth = @dateOfBirth,
  PhoneNumber = @phoneNumber
  WHERE EmployeeCode = @employeeCode
END
GO

<<<<<<< HEAD
CREATE PROCEDURE Employees_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
	SELECT *
  FROM Employee
  WHERE EmployeeCode LIKE N'%' + @searchValue + '%'
    OR EmployeeName LIKE N'%' + @searchValue + '%'
    OR DateOfBirth LIKE N'%' + @searchValue + '%'
    OR PhoneNumber LIKE N'%' + @searchValue + '%'
END
GO

Employee_Insert N'Đỗ Thành Đạt','08/08/2000','01111111'

=======
ALTER TABLE QLKHO.dbo.Commodity
  ADD CONSTRAINT FK_Commodity_Producer FOREIGN KEY (ProducerCode) REFERENCES dbo.Producer (ProducerCode)
GO

-----------------------Thiệp BILL------------------------
CREATE PROCEDURE SP_Bill_GetAll
AS
BEGIN
  SELECT *
  FROM Bill
END
GO

CREATE PROCEDURE SP_Bill_Insert
  @CommodityCode INT,
  @EmployeeCode INT,
  @DateOfExport DATE,
  @NumberOfExport INT
AS
BEGIN
  INSERT INTO Bill
    (CommodityCode, EmployeeCode, DateOfExport, NumberOfExport)
  VALUES(@CommodityCode,@EmployeeCode, @DateOfExport, @NumberOfExport)
END
GO

CREATE PROCEDURE SP_Bill_Delete
  @BillCode INT
AS
BEGIN
  DELETE Bill
  WHERE BillCode = @BillCode
END
GO

CREATE PROCEDURE SP_Bill_Update
  @BillCode INT,
  @CommodityCode INT,
  @EmployeeCode INT,
  @DateOfExport DATE,
  @NumberOfExport INT
AS
BEGIN
  UPDATE Bill
  SET CommodityCode = @CommodityCode,
	  EmployeeCode = @EmployeeCode,
	  DateOfExport = @DateOfExport,
	  NumberOfExport = @NumberOfExport
  WHERE BillCode = @BillCode
END
GO

CREATE PROCEDURE SP_Bill_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM Bill
  WHERE BillCode LIKE N'%' + @searchValue + '%'
    OR  CommodityCode LIKE N'%' + @searchValue + '%'
    OR  EmployeeCode LIKE N'%' + @searchValue + '%'
    OR  DateOfExport LIKE N'%' + @searchValue + '%'
    OR  NumberOfExport LIKE N'%' + @searchValue + '%'
END
GO

CREATE PROCEDURE SP_Employee_GetAll
AS
BEGIN
  SELECT *
  FROM Employee
END
GO

CREATE PROCEDURE SP_Commodity_GetAll
AS
BEGIN
  SELECT *
  FROM Commodity
END
GO
>>>>>>> origin/thieptt
