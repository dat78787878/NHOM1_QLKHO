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