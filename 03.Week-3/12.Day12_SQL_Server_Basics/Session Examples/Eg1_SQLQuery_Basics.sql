  -- Creating database in sql server 
CREATE DATABASE EmployeeDb
 
USE EmployeeDb

 -- Create tables 
 CREATE TABLE Dept
(
	Deptno INT PRIMARY KEY,
	Dname VARCHAR(50),
	Loc VARCHAR(50) 
);

-- insert data into dept table
INSERT INTO Dept VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO Dept VALUES (20,'RESEARCH','DALLAS');
INSERT INTO Dept VALUES (30,'SALES','CHICAGO');
INSERT INTO Dept VALUES (40,'OPERATIONS','BOSTON');
INSERT INTO Dept VALUES (50,'TESTING','CHICAGO');

-- Reading from table
SELECT * FROM Dept;
SELECT Deptno, Dname, Loc FROM Dept;
SELECT Deptno, Dname FROM Dept;


-- Droppign table 
DROP TABLE Dept;	-- Delete data and structure of the table 

----------------------------------------------------------------------------




CREATE TABLE Emps
(
	Empno INT PRIMARY KEY,
	Ename VARCHAR(50),
	Job   VARCHAR(50),
	Salary   DECIMAL(10,2),
	Deptno INT,
	FOREIGN KEY (Deptno) REFERENCES Dept(Deptno)
);


INSERT INTO Emps VALUES(7369,'SMITH','CLERK',800, 20);
INSERT INTO Emps VALUES(7499,'ALLEN','SALESMAN',1600,30);
INSERT INTO Emps VALUES(7521,'WARD','SALESMAN',1250,30);
INSERT INTO Emps VALUES(7566,'JONES','MANAGER',2975,20);

 

SELECT * FROM Emps
SELECT * FROM Emps WHERE Deptno=20
SELECT * FROM Emps WHERE job = 'SALESMAN'
SELECT * FROM Emps WHERE salary < 1300