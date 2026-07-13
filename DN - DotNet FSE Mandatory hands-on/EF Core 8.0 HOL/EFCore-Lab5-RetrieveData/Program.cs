using Microsoft.EntityFrameworkCore;
using EFCore_Lab5_RetrieveData;
using EFCore_Lab5_RetrieveData.Models;

using var context = new AppDbContext();

Console.WriteLine("====================================");
Console.WriteLine("      EF Core 8.0 - Lab 5");
Console.WriteLine("      Retrieving Data");
Console.WriteLine("====================================");

// Retrieve All Products
Console.WriteLine("\nAll Products:");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Id}. {p.Name} - ₹{p.Price}");
}

// Find Product by ID
Console.WriteLine("\nFind Product with ID = 1");

var product = await context.Products.FindAsync(1);

if (product != null)
{
    Console.WriteLine($"Found: {product.Name}");
}
else
{
    Console.WriteLine("Product not found.");
}

// First Product with Price > 50000
Console.WriteLine("\nProduct with Price > 50000");

var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);

if (expensive != null)
{
    Console.WriteLine($"Expensive Product: {expensive.Name}");
}
else
{
    Console.WriteLine("No expensive product found.");
}

Console.WriteLine("\nLab 5 completed successfully!");