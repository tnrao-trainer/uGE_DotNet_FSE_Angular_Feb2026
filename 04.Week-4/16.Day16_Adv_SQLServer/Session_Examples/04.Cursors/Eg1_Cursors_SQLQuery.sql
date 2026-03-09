use EmployeeDb

DECLARE @EmpID INT
DECLARE @Salary DECIMAL(10,2)

-- Step-1. Declare cursor
DECLARE EmployeeCursor CURSOR
FOR
SELECT Empno, Salary FROM Emp

-- Step-2:  Open cursor
OPEN EmployeeCursor

-- Step3: Fetch first row
FETCH NEXT FROM EmployeeCursor INTO @EmpID, @Salary

-- Loop through rows
WHILE @@FETCH_STATUS = 0
BEGIN
    UPDATE Emp
    SET Salary = @Salary * 1.10
    WHERE Empno = @EmpID

    FETCH NEXT FROM EmployeeCursor INTO @EmpID, @Salary
END

-- Step-4:   Close  
CLOSE EmployeeCursor

--Step-5:   Deallocate
DEALLOCATE EmployeeCursor