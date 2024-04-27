CREATE DATABASE catalogue;
GO

USE catalogue;
 
CREATE TABLE dbo.Products
(
    Id INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(128) NOT NULL CHECK (Len(RTrim([Name])) > 0)
);
 
CREATE TABLE dbo.Categories
(
    Id INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(128) NOT NULL CHECK (Len(RTrim([Name])) > 0)
);

CREATE TABLE dbo.ProductsInCategories
(
    ProductId INT,
	CategoryId INT,
	PRIMARY KEY (ProductId, CategoryId),
	FOREIGN KEY (ProductId) REFERENCES dbo.Products (Id) ON DELETE CASCADE,
	FOREIGN KEY (CategoryId) REFERENCES dbo.Categories (Id) ON DELETE CASCADE
);
GO

INSERT dbo.Products
VALUES ('with category'), ('with no category');

INSERT dbo.Categories
VALUES ('with product'), ('with no product');

INSERT dbo.ProductsInCategories
VALUES (1, 1);

GO