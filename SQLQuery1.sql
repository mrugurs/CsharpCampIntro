--Case Insensitive - Büyük küçük harf duyarsız.

--Select
--Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers --bu bir tablodur

--where
--Select * from Customers where City = 'London' or City = 'Berlin'

--Select * from Products where CategoryID = 1 or CategoryID = 3
--Select * from Products where CategoryID = 1 and UnitPrice >= 10

--order by
--Select * from Products Order by CategoryID, ProductName 
--Select * from Products Order by CategoryID, ProductName 

--Select * from Products Order by UnitPrice asc   --ascending - artan
--Select * from Products Order by UnitPrice desc  --descending - azalan

--Select * from Products where CategoryID = 1 order by UnitPrice desc

--count
--Select count(*) from Products --kaç satır var?
--Select count(*) from Products where CategoryID = 2

--group by
--select CategoryID, count(*) Adet from Products group by CategoryID  --
--select CategoryID, count(*) Adet from Products group by CategoryID having count(*)<10
--select count(*) Adet from Products where UnitPrice>20
--select CategoryID, count(*) Adet from Products group by CategoryID having count(*)<10
--select CategoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

--join
--select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID --2 tabloyu birleştirmek
--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID  --2 tabloyu birleştirmek için

--DTO Data Transformation Object
--select * from Products p left join [Order Details] od on p.ProductID = od.ProductID -- solda olup da sağda olmayan
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

