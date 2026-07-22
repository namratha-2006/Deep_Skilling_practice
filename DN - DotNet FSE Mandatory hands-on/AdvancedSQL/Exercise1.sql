USE OnlineRetailDB;
GO

DROP TABLE IF EXISTS Products;
GO
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);
INSERT INTO Products VALUES
(1,'Laptop','Electronics',80000),
(2,'Phone','Electronics',60000),
(3,'TV','Electronics',60000),
(4,'Mouse','Electronics',1500),
(5,'Shirt','Fashion',2000),
(6,'Jeans','Fashion',3000),
(7,'Jacket','Fashion',3000),
(8,'Shoes','Fashion',5000),
(9,'Book','Education',500),
(10,'Notebook','Education',100);
SELECT * FROM Products;
SELECT
ProductID,
ProductName,
Category,
Price,

ROW_NUMBER() OVER
(
PARTITION BY Category
ORDER BY Price DESC
) AS Row_Number

FROM Products;
SELECT
ProductID,
ProductName,
Category,
Price,

RANK() OVER
(
PARTITION BY Category
ORDER BY Price DESC
) AS Rank_Value

FROM Products;
SELECT
ProductID,
ProductName,
Category,
Price,

DENSE_RANK() OVER
(
PARTITION BY Category
ORDER BY Price DESC
) AS Dense_Rank

FROM Products;
SELECT *

FROM
(
SELECT
ProductID,
ProductName,
Category,
Price,

ROW_NUMBER() OVER
(
PARTITION BY Category
ORDER BY Price DESC
) AS Row_Number

FROM Products
) P

WHERE Row_Number<=3;