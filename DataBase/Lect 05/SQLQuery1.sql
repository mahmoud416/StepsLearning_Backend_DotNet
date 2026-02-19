--Display suppliers and the products they supply

SELECT 
    s.SupplierName,
    p.ProductName
FROM Supplier s
INNER JOIN ProductSupplier ps
    ON s.SupplierID = ps.SupplierID
INNER JOIN Product p
    ON ps.ProductID = p.ProductID;

--Display all suppliers for a specific product (given ProductID)

SELECT 
    s.SupplierName,
    s.Phone
FROM Supplier s
INNER JOIN ProductSupplier ps
    ON s.SupplierID = ps.SupplierID
WHERE ps.ProductID = 5;  

--Display products supplied by more than one supplier

SELECT 
    p.ProductName,
    COUNT(ps.SupplierID) AS SupplierCount
FROM Product p
INNER JOIN ProductSupplier ps
    ON p.ProductID = ps.ProductID
GROUP BY p.ProductName
HAVING COUNT(ps.SupplierID) > 1;

--Display products stored in warehouses along with their quantities

SELECT 
    p.ProductName,
    w.Location,
    pw.Quantity
FROM ProductWarehouse pw
INNER JOIN Product p
    ON pw.ProductID = p.ProductID
INNER JOIN Warehouse w
    ON pw.WarehouseID = w.WarehouseID;

    --Display warehouses that store a specific product

    SELECT 
    w.WarehouseID,
    w.Location
FROM Warehouse w
INNER JOIN ProductWarehouse pw
    ON w.WarehouseID = pw.WarehouseID
WHERE pw.ProductID = 3;  


--Display all products included in each order

SELECT 
    o.OrderID,
    p.ProductName
FROM Orders o
INNER JOIN OrderItem oi
    ON o.OrderID = oi.OrderID
INNER JOIN Product p
    ON oi.ProductID = p.ProductID;


--Display order details including product name and quantity

SELECT 
    o.OrderID,
    p.ProductName,
    oi.Quantity
FROM Orders o
INNER JOIN OrderItem oi
    ON o.OrderID = oi.OrderID
INNER JOIN Product p
    ON oi.ProductID = p.ProductID;


--Display the total price of each order item (Quantity × UnitPrice)

SELECT 
    OrderID,
    ProductID,
    Quantity,
    UnitPrice,
    Quantity * UnitPrice AS TotalPrice
FROM OrderItem;


--Display all orders along with their total amounts

SELECT 
    o.OrderID,
    SUM(oi.Quantity * oi.UnitPrice) AS TotalAmount
FROM Orders o
INNER JOIN OrderItem oi
    ON o.OrderID = oi.OrderID
GROUP BY o.OrderID;


--Display orders that contain more than one product

SELECT 
    o.OrderID,
    COUNT(oi.ProductID) AS ProductCount
FROM Orders o
INNER JOIN OrderItem oi
    ON o.OrderID = oi.OrderID
GROUP BY o.OrderID
HAVING COUNT(oi.ProductID) > 1;


--Display the total quantity sold for each product

SELECT 
    p.ProductName,
    SUM(oi.Quantity) AS TotalSold
FROM Product p
INNER JOIN OrderItem oi
    ON p.ProductID = oi.ProductID
GROUP BY p.ProductName;


--Display the top 3 most sold products

SELECT TOP 3
    p.ProductName,
    SUM(oi.Quantity) AS TotalSold
FROM Product p
INNER JOIN OrderItem oi
    ON p.ProductID = oi.ProductID
GROUP BY p.ProductName
ORDER BY TotalSold DESC;


--Display suppliers who supply more than 3 products


SELECT 
    s.SupplierName,
    COUNT(ps.ProductID) AS ProductCount
FROM Supplier s
INNER JOIN ProductSupplier ps
    ON s.SupplierID = ps.SupplierID
GROUP BY s.SupplierName
HAVING COUNT(ps.ProductID) > 3;


--Display warehouses that store more than 100 units in total


SELECT 
    w.WarehouseID,
    w.Location,
    SUM(pw.Quantity) AS TotalQuantity
FROM Warehouse w
INNER JOIN ProductWarehouse pw
    ON w.WarehouseID = pw.WarehouseID
GROUP BY w.WarehouseID, w.Location
HAVING SUM(pw.Quantity) > 100;


--Display categories whose products have an average price

SELECT 
    c.CategoryName,
    AVG(p.Price) AS AvgPrice
FROM Category c
INNER JOIN Product p
    ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName
HAVING AVG(p.Price) > 2000;


