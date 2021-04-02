USE QLKHO
GO

-----------------------BILL------------------------
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