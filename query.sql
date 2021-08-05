SELECT p.Name, c.Name
FROM Products p LEFT JOIN Categories c
ON c.Id = p.CategoryId 