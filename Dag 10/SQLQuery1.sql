-- 2023-10-06
-- Database oprettet på kurset Videregående programmering med C# - Itucation

--- CREATE DB ---

-- CREATE database VoresDB
--USE VoresDB



--- CREATE TABLES ---

--CREATE TABLE Customers(
--	cID INT IDENTITY PRIMARY KEY,
--	cName NVARCHAR(30) NOT NULL,
--	cEmail VARCHAR(45) DEFAULT 'someEmail@example.com',
--	cPhone INT DEFAULT 12345678,
--);

--CREATE TABLE Products(
--	pID INT IDENTITY PRIMARY KEY,
--	pName NVARCHAR(50) NOT NULL,
--	pPrice INT DEFAULT 100,
--);

--CREATE TABLE Orders(
--	oID INT IDENTITY PRIMARY KEY,
--	cID INT FOREIGN KEY REFERENCES dbo.Customers(cID),
--	pID INT FOREIGN KEY REFERENCES dbo.Products(pID),
--	orderDate DateTime DEFAULT CURRENT_TIMESTAMP,
--);


--- ALTER TABLES ---

--ALTER TABLE [dbo].[Orders]
--ADD paymentStatus BIT DEFAULT 0

--ALTER TABLE [dbo].[Orders]
--ADD quantity INT DEFAULT 1


--- INSERT RECORDS ---

--INSERT INTO dbo.Customers(cName, CEmail, cPhone)
--VALUES ('Ib Bo', 'ib@example.com', 11223344), ('Ea', 'ea@example.com', 55667788);

--// Default værdier indsættes i tabellen
--INSERT INTO [dbo].[Customers](cName)
--VALUES ('Cat'), ('Bat'), ('Hat'), ('Matt')

--INSERT INTO [dbo].Products(pName, pPrice)
--VALUES ('TV', 5000), ('Smartphone', 7000), ('Laptop', 6000);

--INSERT INTO [dbo].Products(pName)
--VALUES('Drikkedunk');

--INSERT INTO dbo.Orders(cId, pID)
--VALUES (2, 3), (1, 4), (3, 2), (4, 4);



--- SELECT RECORDS ---

--SELECT *
--FROM dbo.Customers

--SELECT *
--FROM dbo.Customers
--WHERE cId > 3

--SELECT *
--FROM dbo.Products

--SELECT *
--FROM dbo.Products
--WHERE pPrice > 5000

--SELECT *
--FROM dbo.Orders



--- JOINS ---

--SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price', (o.quantity * p.pPrice) AS 'Total Amount'
--FROM [dbo].[Orders] AS o
--JOIN [dbo].[Customers] AS c
--ON o.cID = c.cID
----FROM [dbo].[Products] as p
--JOIN [dbo].[Products] as p
--ON o.pID = p.pID



--- CASE ---

--SELECT	c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
--		(o.quantity * p.pPrice) AS 'Total Amount',
--		CASE
--			WHEN o.paymentStatus = 0 THEN 'NOT Paid'
--			WHEN o.paymentStatus = 1 THEN 'Paid'
--			ELSE 'Contact SysAdmin'
--		END AS 'Payment Status'
--FROM [dbo].[Orders] AS o
--JOIN [dbo].[Customers] AS c
--ON o.cID = c.cID
----FROM [dbo].[Products] as p
--JOIN [dbo].[Products] as p
--ON o.pID = p.pID



--- UDF - User Defined Function ---

--CREATE FUNCTION udf_Betalingsstatus(@n INT)
--RETURNS NVARCHAR(50)
--BEGIN
--	RETURN
--	CASE
--		WHEN @n = 0 THEN 'NOT Paid'
--		WHEN @n = 1 THEN 'Paid'
--		ELSE 'Contact SysAdmin'
--	END
--END

--SELECT [dbo].udf_Betalingsstatus(2)
--SELECT [dbo].udf_Betalingsstatus(1)
--SELECT [dbo].udf_Betalingsstatus(0)

--SELECT	c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
--		(o.quantity * p.pPrice) AS 'Total Amount',
--		[dbo].udf_Betalingsstatus(o.paymentStatus)
--FROM [dbo].[Orders] AS o
--JOIN [dbo].[Customers] AS c
--ON o.cID = c.cID
----FROM [dbo].[Products] as p
--JOIN [dbo].[Products] as p
--ON o.pID = p.pID



--- UPDATE ---

--UPDATE [dbo].[Orders]
--SET paymentStatus = 0;

--UPDATE [dbo].[Orders]
--SET paymentStatus = 1
--WHERE oID = 4

--UPDATE [dbo].[Orders]
--SET quantity = 3
--WHERE oID = 4


--- VIEWS ---

--CREATE VIEW SalesView
--AS
--	SELECT	c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
--			(o.quantity * p.pPrice) AS 'Total Amount',
--			CASE
--				WHEN o.paymentStatus = 0 THEN 'NOT Paid'
--				WHEN o.paymentStatus = 1 THEN 'Paid'
--				ELSE 'Contact SysAdmin'
--			END AS 'Payment Status'
--	FROM [dbo].[Orders] AS o
--	JOIN [dbo].[Customers] AS c
--	ON o.cID = c.cID
--	--FROM [dbo].[Products] as p
--	JOIN [dbo].[Products] as p
--	ON o.pID = p.pID

--SELECT * FROM SalesView


--- XML ---

--SELECT * FROM [dbo].[Customers]
--FOR XML RAW

--SELECT * FROM [dbo].[Customers]
--FOR XML RAW('Customer')

--SELECT * FROM [dbo].[Customers]
--FOR XML AUTO, Elements

--SELECT * FROM [dbo].[Customers]
--FOR XML Path('Customer'), Root('Customers')



--- JSON ---

--SELECT * FROM [dbo].[Customers]
--FOR JSON AUTO


