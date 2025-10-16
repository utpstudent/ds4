-- Ejemplo 1: Mostrar todos los productos
SELECT * FROM Products;

-- Ejemplo 2: Mostrar nombre y precio de los productos
SELECT ProductName, UnitPrice FROM Products;

-- Ejemplo 3: Productos con precio mayor a 20
SELECT * FROM Products WHERE UnitPrice > 20;

-- Ejemplo 4: Productos sin stock
SELECT * FROM Products WHERE UnitsInStock = 0;

-- Ejemplo 5: Productos con precio entre 10 y 30
SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 30;

-- Ejemplo 6: Productos de categoría 1 con stock disponible
SELECT * FROM Products WHERE CategoryID = 1 AND UnitsInStock > 0;

-- Ejemplo 7: Productos que comienzan con 'Ch'
SELECT * FROM Products WHERE ProductName LIKE 'Ch%';

-- Ejemplo 8: Productos que contienen 'cola'
SELECT * FROM Products WHERE ProductName LIKE '%cola%';

-- Ejemplo 9: Productos que no contienen la letra 'a'
SELECT * FROM Products WHERE ProductName NOT LIKE '%a%';

-- Ejemplo 10: Productos donde el segundo carácter es 'a'
SELECT * FROM Products WHERE ProductName LIKE '_a%';

-- Ejemplo 11: Productos que comienzan con letras entre A y C
SELECT * FROM Products WHERE ProductName LIKE '[A-C]%';

-- Ejemplo 12: Ordenar productos por precio ascendente
SELECT * FROM Products ORDER BY UnitPrice ASC;

-- Ejemplo 13: Ordenar productos por nombre descendente
SELECT * FROM Products ORDER BY ProductName DESC;

-- Ejemplo 14: Mostrar categorías únicas
SELECT DISTINCT CategoryID FROM Products;

-- Ejemplo 15: Mostrar los 5 productos más caros
SELECT TOP 5 * FROM Products ORDER BY UnitPrice DESC;

-- Ejemplo 16: Mostrar el 10% de los productos más caros
SELECT TOP 10 PERCENT * FROM Products ORDER BY UnitPrice DESC;

-- Ejemplo 17: Mostrar nombre y precio con alias
SELECT ProductName AS NombreProducto, UnitPrice AS Precio FROM Products;

-- Ejemplo 18: Mostrar ID y nombre con alias
SELECT ProductID AS ID, ProductName AS Producto FROM Products;

-- Ejemplo 19: INNER JOIN entre productos y detalles de orden
SELECT Products.ProductName, [Order Details].OrderID
FROM Products
INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID;

-- Ejemplo 20: FULL JOIN entre productos y proveedores
SELECT Products.ProductName, Suppliers.CompanyName
FROM Products
FULL JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID;