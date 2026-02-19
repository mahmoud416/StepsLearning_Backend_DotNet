select * from Product

select ProductName , price from product

select * from Category

select price from Product
where price > 1000

select * from Orders
where status = 'Completed'

select * from Supplier
select suppliername , phone from Supplier


select p.productname , c.categoryname
from product p inner join Category c
on p.CategoryID = c.CategoryID

select * , c.categoryname 
from Product p inner join Category c
on p.CategoryID = c.CategoryID
where c.CategoryName='Elactroinc'

select c.categoryname , COUNT(p.productid)
from Category c inner join product p
on c.CategoryID = p.CategoryID

select c.CategoryID , c.CategoryName
from Category c left outer join product p
on c.CategoryID = p.CategoryID

select p.productname , p.ManufacturingDate , c.categoryName
from product p inner join Category c
on p.CategoryID = c.CategoryID

