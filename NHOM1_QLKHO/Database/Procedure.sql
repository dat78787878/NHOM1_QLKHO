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
  @phoneNumber varchar(50)
AS
BEGIN
  INSERT INTO Employee
    (FullName, DateOfBirth, PhoneNumber)
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
  @EmployeeCode INT,
  @fullName NVARCHAR(50),
  @dateOfBirth date,
  @phoneNumber varchar(50)
AS
BEGIN
  UPDATE Employee
  SET FullName  = @fullName,
  DateOfBirth = @dateOfBirth,
  PhoneNumber = @phoneNumber
  WHERE EmployeeCode = @EmployeeCode