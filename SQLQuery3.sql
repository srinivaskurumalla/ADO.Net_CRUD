Select * from Employee
Select * into EmployeeBackUp from Employee
Select * from EmployeeBackUp
Delete from EmployeeBackUp

Select * from Products
Select ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock from Products where ProductID =1

go
Create Proc usp_GetProductsById(@ProductId int)
as
if(exists(Select 'a' from Products Where ProductID=@ProductId))
    Select ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock from Products Where ProductId=@ProductId

go
Create Proc usp_InsertProducts(@ProductName varchar(50), @SupplierID int, @CategoryID int, @QuantityPerUnit varchar(50), @UnitPrice money, @UnitsInStock smallint)
as
if(not exists(Select 'a' from Products Where ProductName = @ProductName))
    Insert Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock)
    values (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit,@UnitPrice, @UnitsInStock)
else
    Throw 50001, 'Product Name already exist',1
---======================================
go
ALter Proc usp_InsertProducts(@ProductName varchar(50), @SupplierID int, @CategoryID int, @QuantityPerUnit varchar(50), @UnitPrice money, @UnitsInStock smallint,@Id int OUT)
as
if(not exists(Select 'a' from Products Where ProductName = @ProductName))
  begin
    Insert Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock)
    values (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit,@UnitPrice, @UnitsInStock)
    SET @Id = IDENT_CURRENT('Products')
  end
else
    Throw 50001, 'Product Name already exist',1

 
 go
Create Proc usp_UpdateProduct(@ProductId int, @UnitPrice money, @UnitsInStock smallint)
as
if(exists(Select 'a' from Products Where ProductID=@ProductId))
begin
    Update Products SET UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock Where ProductID = @ProductId
end
else
    Throw 50001, 'ProductId does not exists',1


go
Create Proc usp_DeleteProductById(@ProductId int)
as
if(exists(Select 'a' from Products Where ProductID = @ProductId))
    begin
        Delete From Products Where ProductID = @ProductId
    end
else
    Throw 50001, 'ProductId does not exists',1
go

Alter Proc usp_DeleteProductById(@ProductId int OUT,@Id int OUT )
as
if(exists(Select 'a' from Products Where ProductID = @ProductId))
    begin
        Delete From Products Where ProductID = @ProductId
        SET @Id = IDENT_CURRENT('Products')
       
    end
else
    Throw 50001, 'ProductId does not exists',1

/*
go
Create Proc usp_EditProduct(@ProductId int, @UnitPrice money, @UnitsInStock smallint)
as
if(exists(Select 'a' from Products Where ProductID=@ProductId))
begin
    Update Products SET UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock Where ProductID = @ProductId
end
else
    Throw 50001, 'ProductId does not exists',1
drop proc usp_EditProduct
*/


