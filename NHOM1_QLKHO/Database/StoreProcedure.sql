-----------------------BILL------------------------
CREATE PROCEDURE SP_Bill_GetAll
AS
BEGIN
  SELECT *
  FROM Bill
END
GO

CREATE PROCEDURE SP_Bill_Insert
  @BillCode VARCHAR(10),
  @CommodityCode VARCHAR(10),
  @EmployeeCode VARCHAR(10),
  @DateOfExport DATE,
  @NumberOfExport INT
AS
BEGIN
  INSERT INTO Bill
    (BillCode, CommodityCode, EmployeeCode, DateOfExport, NumberOfExport)
  VALUES(@BillCode, @CommodityCode,@EmployeeCode, @DateOfExport, @NumberOfExport)
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
  @BillCode VARCHAR(10),
  @CommodityCode VARCHAR(10),
  @EmployeeCode VARCHAR(10),
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