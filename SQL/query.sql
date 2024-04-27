USE catalogue;

SELECT P.[Name] AS [Product Name], C.[Name] AS [Category Name]
FROM dbo.ProductsInCategories AS PC
JOIN dbo.Categories AS C
ON PC.CategoryId = C.Id
RIGHT JOIN dbo.Products AS P
ON PC.ProductId = P.Id;

GO
