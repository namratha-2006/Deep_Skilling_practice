using EFCore_Lab4_InsertData;
using EFCore_Lab4_InsertData.Models;

using var context = new AppDbContext();

// Create Categories
var electronics = new Category
{
    Name = "Electronics"
};

var groceries = new Category
{
    Name = "Groceries"
};

// Insert Categories
await context.Categories.AddRangeAsync(electronics, groceries);

// Create Products
var product1 = new Product
{
    Name = "Laptop",
    Price = 75000,
    Category = electronics
};

var product2 = new Product
{
    Name = "Rice Bag",
    Price = 1200,
    Category = groceries
};

// Insert Products
await context.Products.AddRangeAsync(product1, product2);

// Save to Database
await context.SaveChangesAsync();

Console.WriteLine("===================================");
Console.WriteLine(" EF Core 8.0 - Lab 4");
Console.WriteLine("===================================");
Console.WriteLine("Data inserted successfully!");
Console.WriteLine("Categories: Electronics, Groceries");
Console.WriteLine("Products: Laptop, Rice Bag");