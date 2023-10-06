--create database VoresDB
--use VoresDB

CREATE TABLE Customers(
cID int identity primary key,
cName nvarchar(30) NOT NULL,
cEmail varchar(45) default 'bla@bla.dk',
cPhone int default 12345678
);

---- INSERT RECORDS ----
INSERT dbo.Customers(cName, cEmail, cPhone)
VALUES('Mark', 'mark@mail.dk', 12344455),
('Charlotte', 'CMM@mail.dk', 87654321)

SELECT * FROM dbo.Customers
WHERE cID > 3

INSERT dbo.Customers(cName)
VALUES ('Lisa'), ('Lars'), ('Marie'), ('Ole')

CREATE TABLE Products(
pID int identity primary key,
pName nvarchar(50) not null,
pPrice int default 100
);

INSERT dbo.Products(pName, pPrice)
VALUES('TV', 5000), ('Smartphone', 7000), ('Laptop', 6000)

INSERT dbo.Products(pName)
VALUES('Drikkedunk')

SELECT * FROM dbo.Products

CREATE TABLE Orders(
oID int identity primary key,
cID int foreign key references dbo.Customers(cID),
pID int foreign key references dbo.Products(pID),
orderDate DateTime default current_timestamp
);

INSERT dbo.Orders(cID, pID)
VALUES(2,3), (1,4), (3,2),(4,4)

SELECT * FROM dbo.Orders

---- JOIN ----
SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price'
FROM dbo.Orders as o
JOIN dbo.Customers as c
ON o.cID = c.cID
JOIN dbo.Products as p
ON o.pID = p.pID

---- ALTER ----
ALTER TABLE dbo.Orders
ADD paymentStatus bit default 0

ALTER TABLE dbo.Orders
ADD quantity int default 1

select * from dbo.Orders

---- UPDATE ----
UPDATE dbo.Orders
SET paymentStatus = 1
where oID = 4

UPDATE dbo.Orders
set quantity = 3
where oID = 4

SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
				(o.quantity * p.pPrice) as 'Total Amount'
FROM dbo.Orders as o
JOIN dbo.Customers as c
ON o.cID = c.cID
JOIN dbo.Products as p
ON o.pID = p.pID

---- CASE ----
SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
				(o.quantity * p.pPrice) as 'Total Amount',
				CASE
					WHEN o.paymentStatus = 0 THEN 'NOT Paid'
					WHEN o.paymentStatus = 1 THEN 'Paid'
					ELSE 'Contact SysAdmin'
				END AS 'Payment Status'
FROM dbo.Orders as o
JOIN dbo.Customers as c
ON o.cID = c.cID
JOIN dbo.Products as p
ON o.pID = p.pID

---- UDF - User Defined Function ----
CREATE FUNCTION Betalingsstatus(@n int)
RETURNS nvarchar(50)
BEGIN
	RETURN
	CASE
		WHEN @n = 0 THEN 'NOT Paid'
		WHEN @n = 1 THEN 'Paid'
		ELSE 'Contact SysAdmin'
	END
END

SELECT dbo.Betalingsstatus(1)

SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
				(o.quantity * p.pPrice) as 'Total Amount',
				dbo.Betalingsstatus(o.paymentStatus) as 'Payment Status'
FROM dbo.Orders as o
JOIN dbo.Customers as c
ON o.cID = c.cID
JOIN dbo.Products as p
ON o.pID = p.pID

---- View ----
CREATE VIEW SalesView
AS
SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
				(o.quantity * p.pPrice) as 'Total Amount',
				dbo.Betalingsstatus(o.paymentStatus) as 'Payment Status'
FROM dbo.Orders as o
JOIN dbo.Customers as c
ON o.cID = c.cID
JOIN dbo.Products as p
ON o.pID = p.pID

SELECT * FROM SalesView

----- XML -----
SELECT * FROM dbo.Customers
FOR XML raw
---------------
SELECT * FROM dbo.Customers
FOR XML raw('Customer')
---------------
SELECT * FROM dbo.Customers
FOR XML Auto, Elements
---------------
SELECT * FROM dbo.Customers
FOR XML Path('Customer'), Root('Customers')
---------------
SELECT * FROM dbo.Customers
FOR JSON Auto