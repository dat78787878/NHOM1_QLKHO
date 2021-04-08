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

---------------- Văn ----------------

-- Thu tuc lay danh sach hang hoa trong kho
create proc GetCommodityList
as
begin
	select *
	from Commodity
end
go
-- Hàm chuyển chuối có dấu thành không dấu
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
go
-- Tim kiem hang hoa theo ten
create proc SearchCommodityByName
	@commodityname nvarchar(50)
as
begin
	select *
	from Commodity
	where [dbo].[GetUnsignString](CommodityName) like N'%' + [dbo].[GetUnsignString](@commodityname) + '%'
end

-- Trigger cap nhat so luong hang khi nhap xuat
create trigger AmountCommodityForInsDelBill on Bill
for insert, delete, update
as
begin
	update Commodity
	set Amount = Amount - (
		select NumberOfExport
		from inserted
		where CommodityCode = Commodity.CommodityCode
		) + (
		select NumberOfExport
		from deleted
		where CommodityCode = Commodity.CommodityCode
		)
end
go

create trigger AddAmountCommodityForAddEnterCoupon on EnterCoupon
for insert
as
begin
	declare @check int
	declare @amoutimport int

	select @check = count(*)
	from inserted
	where CommodityCode in (select CommodityCode
							from Commodity)

	if(@check > 0) 
		update Commodity
		set Amount = Amount - (
			select NumberOfImport
			from inserted
			where CommodityCode = Commodity.CommodityCode
			)
	 else 
		select @amoutimport = NumberOfImport
		from inserted

		insert into Commodity(CommodityName,DateOfManufacture,ExpiryDate,ProducerCode,Amount) values('','','',NULL,@amoutimport)	
end
go

create trigger DecreaseAmountForDeleteEnterCoupon on EnterCoupon
for delete
as
begin
	update Commodity
	set Amount = Amount - (
			select NumberOfImport
			from deleted
			where CommodityCode = Commodity.CommodityCode
			)
end
go

create trigger UpdateAmountForUpdateEnterCoupon on EnterCoupon
for update
as
begin
	declare @check int
	declare @amoutimport int

	select @check = count(*)
	from deleted
	where CommodityCode in (select CommodityCode
							from Commodity)

	if(@check > 0) 
		update Commodity
		set Amount = Amount - (
			select NumberOfImport
			from inserted
			where CommodityCode = Commodity.CommodityCode
			) + (
			select NumberOfImport
			from deleted
			where CommodityCode = Commodity.CommodityCode
			)
	 else 
		select @amoutimport = NumberOfImport
		from inserted

		insert into Commodity(CommodityName,DateOfManufacture,ExpiryDate,ProducerCode,Amount) values('','','',NULL,@amoutimport)
end




----------------. /Văn ---------------