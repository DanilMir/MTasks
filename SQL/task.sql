SELECT 
  Product.Name as "Имя продукта", 
  Category.Name as "Имя категории" 
FROM 
  Product 
  LEFT JOIN ProductCategory on Product.ProductId = ProductCategory.ProductId 
  LEFT JOIN Category on ProductCategory.CategoryId = Category.CategoryId