CREATE TABLE Products (
	Id int NOT NULL PRIMARY KEY,
	Name varchar(255),
);

INSERT INTO Products (Id, Name) VALUES (1, '���');
INSERT INTO Products (Id, Name) VALUES (2, '�����');
INSERT INTO Products (Id, Name) VALUES (3, '�������');
INSERT INTO Products (Id, Name) VALUES (4, '������');
INSERT INTO Products (Id, Name) VALUES (5, '��������');
INSERT INTO Products (Id, Name) VALUES (6, '����');
INSERT INTO Products (Id, Name) VALUES (7, '������');
INSERT INTO Products (Id, Name) VALUES (8, '�������');
INSERT INTO Products (Id, Name) VALUES (9, '�������');
INSERT INTO Products (Id, Name) VALUES (10, '��������');
INSERT INTO Products (Id, Name) VALUES (11, '������');

CREATE TABLE Categories (
	Id int NOT NULL PRIMARY KEY, 
	Name varchar(255),
);

INSERT INTO Categories (Id, Name) VALUES (1, '�����');
INSERT INTO Categories (Id, Name) VALUES (2, '�����');
INSERT INTO Categories (Id, Name) VALUES (3, '������');
INSERT INTO Categories (Id, Name) VALUES (4, '����');

CREATE TABLE ProductsCategories(
	ProductId int,
	CategoryId int,
	CONSTRAINT ProductsCategoriesPK PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (1, 1);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (2, 1);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (3, 3);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (4, 3);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (5, 3);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (6, 1);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (7, 2);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (8, 2);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (9, 3);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (10, 3);
INSERT INTO ProductsCategories (ProductId, CategoryId) VALUES (11, 0);

SELECT Products.Name, Categories.Name 
	FROM Products LEFT OUTER JOIN ProductsCategories ON ProductsCategories.ProductId = Products.Id
				  LEFT OUTER JOIN Categories ON ProductsCategories.CategoryId = Categories.Id;