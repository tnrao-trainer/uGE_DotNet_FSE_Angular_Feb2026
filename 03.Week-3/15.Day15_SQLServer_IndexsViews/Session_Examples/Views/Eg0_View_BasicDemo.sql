

use EmployeeDb


CREATE VIEW vw_GetEmpByDeptno AS
SELECT Ename, Job, Deptno 
FROM Emp
WHERE Deptno=10;


-- Reading data from view /  Querying the view
SELECT * FROM vw_GetEmpByDeptno;
SELECT Ename, Job FROM vw_GetEmpByDeptno;


ALTER VIEW vw_GetEmpByDeptno AS
SELECT Ename, Job, Deptno, Salary
FROM Emp
WHERE Deptno=30;


-- Rename the view
EXEC sp_rename 'vw_GetEmpByDeptno','vw_GetNewEmpByDeptno'


-- Dropping the view
DROP VIEW vw_GetEmpByDeptno; 

SELECT * FROM vw_GetNewEmpByDeptno
DROP VIEW vw_GetNewEmpByDeptno; 



