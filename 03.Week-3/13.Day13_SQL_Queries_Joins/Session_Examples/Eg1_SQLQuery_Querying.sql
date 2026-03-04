
-- Day13:  04-03-2026 -  SQL Queries
---------------------------------------------

CREATE TABLE Dept (
    Deptno INT PRIMARY KEY,
    Dname VARCHAR(30),
    Loc VARCHAR(30)
);

CREATE TABLE Emp (
    Empno INT PRIMARY KEY,
    Ename VARCHAR(30),
    Job VARCHAR(30),
    Salary INT,
    Deptno INT,
    FOREIGN KEY (Deptno) REFERENCES Dept(Deptno)
);


-- DML Commands



-- a.  Create  Operation
INSERT INTO Dept VALUES
(10,'HR','Hyderabad'),
(20,'IT','Bangalore'),
(30,'Sales','Chennai'),
(40,'Finance','Mumbai');

INSERT INTO Emp VALUES
(101,'Ravi','Manager',60000,10),
(102,'Sita','Developer',45000,20),
(103,'Arjun','Developer',50000,20),
(104,'Meena','Sales Executive',35000,30),
(105,'Kiran','Accountant',40000,40),
(106,'John','Manager',65000,20),
(107,'Anita','HR Executive',30000,10),
(108,'Raj','Sales Executive',37000,30);


--  b. Read Operation
SELECT * FROM Dept ;
SELECT * FROM Emp ;
SELECT * FROM Emp WHERE Empno = 101;


--  c. Update Operation
UPDATE Emp  SET Salary =56000	
UPDATE Emp  SET Salary =56000  WHERE Empno = 101



--  d. Delete Operation
DELETE FROM Emp
DELETE FROM Dept

------------------------------------------------------


-- Dropping Entire table 
DROP TABLE Emps


------------------------------------------------------------------------

--   Filtering,  Sorting,  Grouping  :   Where,  Group By, OrderBy, Having, Aggregate Functions

-------------------------------------------------------------------------------

--  1. Basic Queries
--  ~~~~~~~~~~~~~~~~~~

-- 1. Display all employee records from the Emp table.
		SELECT * FROM Emp ;

-- 2. Display employee name and job.
		SELECT ename, job  FROM Emp ;

-- 3. Display employee name and salary.
		SELECT ename, salary  FROM Emp ;

--  4. Display all department details.
		SELECT * FROM Dept; 

--  5. Display distinct job roles in the company.
		
		SELECT DISTINCT(job)  FROM Emp ;


---------------------------------------------------------------------

-- 2. Sorting (ORDER BY)

-- 6. Display employees sorted by salary in ascending order.
	SELECT *  FROM Emp  Order By Salary
	SELECT Ename, Salary  FROM Emp  Order By Salary

-- 7. Display employees sorted by salary in descending order.
		SELECT Ename, Salary  FROM Emp  Order By Salary DESC

 --- 8. Display employees sorted by name alphabetically.
		SELECT * FROM Emp ORDER BY ename ASC;

-- 9. Display employees sorted by department number then salary.
			SELECT Ename, Deptno, Salary FROM Emp ORDER BY Deptno, Salary;

--  10. Display employees with highest salary first.

		SELECT TOP 1 Ename, Salary  FROM Emp  Order By Salary DESC;



		SELECT Max(Salary)  FROM Emp  
		SELECT  Ename, Salary   FROM Emp  WHERE Salary = (SELECT Max(Salary)  FROM Emp)


------------------------------------------------------------------------------------


 --  3. WHERE Clause (Filtering)

--  11. Display employees whose salary is greater than 40000.
	SELECT  Ename, Salary   FROM Emp  WHERE Salary > 40000

-- 12. Display employees working in department 20.
	SELECT  Ename, Salary, Deptno   FROM Emp  WHERE Deptno = 20
	

-- 13. Display employees whose job is 'Manager'.
		SELECT  Ename, Salary,Job  FROM Emp  WHERE Job = 'Manager'

-- 14. Display employees whose salary is less than 35000.
SELECT  Ename, Salary   FROM Emp  WHERE Salary < 35000
	
-- 15. Display employees whose salary is between 30000 and 50000.
	SELECT  Ename, Salary   FROM Emp  WHERE Salary  BETWEEN 30000 AND 50000; 

---------------------------------------------------------
 -- 4. Filtering with Multiple Conditions
--- ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

-- 16. Display employees working in department 20 with salary greater than 45000.
SELECT  Ename, Salary, Deptno   FROM Emp  WHERE Deptno = 20 AND Salary > 45000 

--  17. Display employees whose job is Developer or Manager.
	SELECT  Ename, Salary,Job  FROM Emp  WHERE Job = 'Manager' OR Job = 'Developer'
	
-- 18. Display employees not working in department 10.
		
		SELECT  Ename, Salary, Deptno   FROM Emp  WHERE Deptno <> 10


-- 19. Display employees whose name starts with 'R'.
	SELECT  Ename, Salary, Deptno   FROM Emp  WHERE Ename LIKE  'R%'
	SELECT  Ename, Salary, Deptno   FROM Emp  WHERE Ename LIKE  '_a%'
		

-- 20. Display employees whose salary is not equal to 40000.

	SELECT  Ename, Salary   FROM Emp  WHERE Salary <> 40000

									
-------------------------------------------------------------------------------


-- *****  Aggregate Functions  ****

--  21. Find the total number of employees.
		SELECT count(*) FROM Emp;

--  22. Find the average salary of employees.
	SELECT AVG(salary) FROM Emp;
	SELECT AVG(Salary) AS AverageSalary FROM Emp;


--  23. Find the maximum salary in the company.
		SELECT MAX(Salary) AS MaxSalary FROM Emp;

--  24. Find the minimum salary in the company.
		SELECT MIN(Salary) AS MinSalary FROM Emp;

--  25. Find the total salary paid to all employees.

	SELECT SUM(Salary) AS TotalSalary FROM Emp		


----------------------------------------------------------------
--  ***********  Usage of Group By ******************
--------------------------------------------------------

-- 26.Display the number of employees in each department.

		SELECT count(*) FROM Emp Group By Deptno 
		SELECT Deptno, count(*) FROM Emp Group By Deptno 

	--	SELECT Job, count(*) FROM Emp Group By Deptno    -- Invalid query, raise error

--- 27. Display the average salary for each department.

			SELECT Deptno, AVG(Salary) FROM Emp Group By Deptno 


	---		28. Display the total salary for each department.
			SELECT Deptno, SUM(Salary) FROM Emp Group By Deptno 

	---    29. display the maximum salary in each department.

			SELECT Deptno, Max(Salary) As MaxSalary FROM Emp Group By Deptno 


--  Having clause

	--- 30. Display departments whose total salary is greater than 80000.
		SELECT Deptno, Sum(Salary) As TotalSalary 
		FROM Emp 
		Group By Deptno
		Having  Sum(Salary) > 80000





