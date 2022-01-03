--Select
--ANSII
Select ContactName,CompanyName,City from Customers

Select * from Customers where City = 'Berlin'

--case insensitive ==> büyük, küçük harf duyarsız.

sElEct * from Products where categoryId=1 or categoryId=3

sElect * from Products where categoryId=1 and UnitPrice>10

--order by ==> sırala
select * from Products where categoryId=1 order by UnitPrice

--asc ==> ascending ; azalan   desc ==> descending ; artan

select * from Products where categoryId=1 order by UnitPrice desc

select * from products where CategoryID=2 order by UnitPrice asc

--count() ==> adet
select count(*) from Products 

--group by ==> grupla
select categoryId from Products group by CategoryID

select categoryId, count(*) from Products group by CategoryID

select categoryId, count(*) from Products group by CategoryID having count(*)<10

select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10


--inner join ortakları birleştirir
select *
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * 
from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

--left join => ortakları ve solda olan ama sağda olmayanlarıda birleştirir.
select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is Null 

--right join => ortakları ve sağda olan ama solda olmayanlarıda birleştirir.
select * 
from Orders o right join Customers c
on o.CustomerID = c.CustomerID
where o.CustomerID is null


--çoklu inner join kullanımı
select *
from Products p inner join [Order Details] od
on p.ProductId = od.ProductId
inner join Orders o
on o.OrderId = od.OrderID
