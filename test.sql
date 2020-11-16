Create Table Order(

	OrderId INT NOT NULL IDENTITY(100,1) PRIMARY KEY,
	ProductId INT NOT NULL,
	CustomerId INT NOT NULL
	
);

Create Table Customers(
	CustomerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FIRSTNAME NVARCHAR(40) NOT NULL,
	LASTNAME NVARCHAR(40) NOT NULL,
	CARDNUMBER NVARCHAR(16) NOT NULL,
)

Create Table Product(
	ProductId INT NOT NULL IDENTITY(100,1) PRIMARY KEY,
	NAME NVARCHAR(40) INT NOT NULL,
	PRICE MONEY NOT NULL;
)

Alter Table Order
Add FOREIGN KEY (ProductId) REFERENCES Product(ProductId);

Alter Table Order
Add FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId);



INSERT INTO Customers (FirstName, LastName, Email, Phone)
VALUES 
('Jordan', 'Garcia', 'jg@gmail.com', '888123123455'),
('Isidro', 'Buenro', 'Ib@yahoo.com', '342526234455'),
('Gabby', 'McDude', 'gb@yahoo.com', '889219454555'),
('Tina', 'Smith', 'TS@crouton.net', '345819534755'), -- inserting tina smith


INSERT Into Product (Name, PRICE)
VALUES 
("IPAD", 300),
("IPHONE", 200),
("IPOD", 100),
("NANO", 50);

INSERT INTO Order (ProductId, CustomerId)
VALUES 
(4,2), --Tina buying an iphone
(4,1),
(1,4);

Select * From Order -- display all orders
Where OrderId=104;

Select SUM(PRICE) From Order
Inner Join Product on Product.OrderId = Order.OrderId
where ProductId = 4

Update Product
Set PRICE=250
where ProductId=2;