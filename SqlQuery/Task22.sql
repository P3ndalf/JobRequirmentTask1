CREATE TABLE Products (
	Id int NOT NULL PRIMARY KEY,
	Name varchar(255),
);

INSERT INTO Products (Id, Name) VALUES (1, 'Рис');
INSERT INTO Products (Id, Name) VALUES (2, 'Греча');
INSERT INTO Products (Id, Name) VALUES (3, 'Морковь');
INSERT INTO Products (Id, Name) VALUES (4, 'Персик');
INSERT INTO Products (Id, Name) VALUES (5, 'Говядина');
INSERT INTO Products (Id, Name) VALUES (6, 'Овес');
INSERT INTO Products (Id, Name) VALUES (7, 'Огурец');
INSERT INTO Products (Id, Name) VALUES (8, 'Капуста');
INSERT INTO Products (Id, Name) VALUES (9, 'Свинина');
INSERT INTO Products (Id, Name) VALUES (10, 'Баранина');
INSERT INTO Products (Id, Name) VALUES (11, 'Карась');

CREATE TABLE Categories (
	Id int NOT NULL PRIMARY KEY, 
	Name varchar(255),
);

INSERT INTO Categories (Id, Name) VALUES (1, 'Зерно');
INSERT INTO Categories (Id, Name) VALUES (2, 'Овощи');
INSERT INTO Categories (Id, Name) VALUES (3, 'Фрукты');
INSERT INTO Categories (Id, Name) VALUES (4, 'Мясо');

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