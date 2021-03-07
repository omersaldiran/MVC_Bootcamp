--Select
Select CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'

Select * from Products where CategoryID = 1

select * from Products order by UnitPrice desc

select COUNT(*) from Products

select CategoryID,COUNT(*) Adet from Products group by CategoryID having count(*)<10

select * from Products inner join Categories
on Products.CategoryID = Categories.CategoryID