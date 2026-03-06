
USE EmployeeDb


CREATE NONCLUSTERED INDEX
idx_ename
ON Emp (Ename); 


CREATE NONCLUSTERED INDEX
idx_deptno
ON Emp (Deptno); 




-- Unique Index 
CREATE UNIQUE INDEX
idx_email
ON Emp (email); 


-- To view all indexes on the given table 
EXEC sp_helpindex  'Emp'


-- Rebuild and Reorganize an Index

ALTER INDEX ALL ON Emp  REORGANIZE;
ALTER INDEX idx_ename ON Emp  REORGANIZE;



ALTER INDEX ALL ON Emp  REBUILD;
ALTER INDEX idx_ename ON Emp  REBUILD;


ALTER INDEX idx_ename ON Emp  DISABLE;
ALTER INDEX idx_ename ON Emp  REBUILD;   --  To enable  disabled index

-- Drop Index
DROP INDEX idx_ename ON Emp; 













