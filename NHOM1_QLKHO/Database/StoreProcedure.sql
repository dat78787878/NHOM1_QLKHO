use QLKHO
GO
-----------------------hàng hóa------------------------
CREATE PROCEDURE SP_HangHoa_GetAll
AS
BEGIN
  SELECT *
  FROM Commodity
END
GO


CREATE PROCEDURE SP_HangHoa_Insert
  @CommodityName NVARCHAR(50),
  @DateOfManufacture DATE,
  @ExpiryDate DATE,
  @ProducerCode int
  
AS
BEGIN
  INSERT INTO Commodity(CommodityName,DateOfManufacture,ExpiryDate,ProducerCode)
  VALUES(@CommodityName,@DateOfManufacture,@ExpiryDate,@ProducerCode)
END
GO

CREATE PROCEDURE SP_HangHoa_Delete
  @CommodityCode int
AS
BEGIN
  
  DELETE Commodity
  WHERE CommodityCode = @CommodityCode
END
GO

CREATE PROCEDURE SP_HangHoa_Update
  @CommodityCode int,
  @CommodityName NVARCHAR(50),
  @DateOfManufacture DATE,
  @ExpiryDate DATE,
  @ProducerCode int
  
AS
BEGIN
  UPDATE Commodity
  SET 
      CommodityName=@CommodityName,
	  DateOfManufacture=@DateOfManufacture,
	  ExpiryDate=@ExpiryDate,
	  ProducerCode=@ProducerCode
	
  
  WHERE CommodityCode = @CommodityCode
END
GO


CREATE PROCEDURE SP_HangHoa_Search
  @searchValue NVARCHAR(50)
AS
BEGIN
  SELECT *
  FROM Commodity
  WHERE CommodityCode LIKE N'%' + @searchValue + '%'
    OR CommodityName LIKE N'%' + @searchValue + '%'
    OR DateOfManufacture LIKE N'%' + @searchValue + '%'
    OR ExpiryDate LIKE N'%' + @searchValue + '%'
    OR ProducerCode LIKE N'%' + @searchValue + '%'
END   
GO
