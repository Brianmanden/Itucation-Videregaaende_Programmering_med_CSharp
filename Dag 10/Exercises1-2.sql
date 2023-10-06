----- Exercise 1 ---

--Create a Database called TestDB

--CREATE DATABASE TestDB
--USE TestDB



--Create a table called Persons. You decide how many columns, but at minimum include an id and a name.

--CREATE TABLE Persons(
--	pID INT IDENTITY PRIMARY KEY,
--	pName NVARCHAR(50) NOT NULL,
--	pPhone INT DEFAULT 11223344,
--	pEmail NVARCHAR(50) DEFAULT 'noEmailEntered@example.com',
--);



--Insert some records - at least three.

--INSERT INTO Persons(pName, pPhone, pEmail)
--VALUES ('Kasper', 99887766, 'k@kardemomme.dk'), ('Jepper', 42421122, 'j@kardemomme.dk'), ('Johnny M.', 36457899, 'j@madsen.dk') 



--Read all the records inserted into your table.

--SELECT * FROM Persons



--Delete TestDB

--USE Master;
--GO
--DROP DATABASE TestDB;
--GO



----- Exercise 2 ---
--a. Use either VoresDB or create a new Database
--USE VoresDB



--b. Create two tables with the following columns, 
--   you choose the data types (but some make more sense than others):
--    - Departments(dID, dName, location)

--CREATE TABLE Departments(
--	dID INT IDENTITY PRIMARY KEY,
--	dName NVARCHAR(50) NOT NULL DEFAULT 'Department Name not set',
--	[location] NVARCHAR(4) DEFAULT '0000',
--);

--    - Employees(eID, eName, dID, Salary)

--CREATE TABLE Employees(
--	eID INT IDENTITY PRIMARY KEY,
--	eName NVARCHAR(50) NOT NULL DEFAULT 'Employee Name not set',
--	salary DECIMAL (5,2) DEFAULT '0',
--);



--c. Insert at least two records into your Departments table.
--INSERT INTO Departments (dName, [location])
--VALUES ('Øst', 4000), ('Midt', 5000), ('Vest', 6871)



--   Insert at least five records into your Employees table.
--INSERT INTO Employees (eName, salary)
--VALUES ('LL', 150), ('Joe', 125), ('Jack', 120), ('William', 115), ('Averell', 110)



--d. Your company needs an executive report about the employees!
--   Query the names of the employees, and how much they make.

--SELECT *
--FROM Employees



--c. Update your executive report to include who works where.
--ALTER TABLE Employees
--ADD Department NVARCHAR(4) DEFAULT '0000'

--UPDATE Employees
--SET Department = '4000' -- Roskilde
--WHERE eName = 'LL'

--UPDATE Employees
--SET Department = '6871' -- Ølgod
--WHERE eName = 'Joe'

--UPDATE Employees
--SET Department = '6871'
--WHERE eName = 'Jack'

--UPDATE Employees
--SET Department = '6871'
--WHERE eName = 'William'

--UPDATE Employees
--SET Department = '5000' -- O´ense
--WHERE eName = 'Averell'

--SELECT e.eName, d.dName 'Department'
--FROM Employees AS e
--JOIN Departments AS d
--ON e.Department = d.[location]