// Assignment 3: LINQ – Product Sales Report


// ProductSale Class

public class ProductSale
{
    public string ProductName { get; set; }
    public string Category { get; set; }
    public int UnitsSold { get; set; }
    public decimal UnitPrice { get; set; }
}


// Main Method with LINQ Queries

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample data across 3 categories
        List<ProductSale> sales = new List<ProductSale>
        {
            new ProductSale { ProductName = "Laptop", Category = "Electronics", UnitsSold = 20, UnitPrice = 750 },
            new ProductSale { ProductName = "Smartphone", Category = "Electronics", UnitsSold = 50, UnitPrice = 500 },
            new ProductSale { ProductName = "Headphones", Category = "Electronics", UnitsSold = 70, UnitPrice = 80 },
            new ProductSale { ProductName = "Shirt", Category = "Apparel", UnitsSold = 100, UnitPrice = 25 },
            new ProductSale { ProductName = "Jeans", Category = "Apparel", UnitsSold = 60, UnitPrice = 40 },
            new ProductSale { ProductName = "Jacket", Category = "Apparel", UnitsSold = 30, UnitPrice = 120 },
            new ProductSale { ProductName = "Coffee Maker", Category = "Home Appliances", UnitsSold = 25, UnitPrice = 150 },
            new ProductSale { ProductName = "Microwave", Category = "Home Appliances", UnitsSold = 15, UnitPrice = 300 },
            new ProductSale { ProductName = "Vacuum Cleaner", Category = "Home Appliances", UnitsSold = 10, UnitPrice = 250 },
            new ProductSale { ProductName = "Blender", Category = "Home Appliances", UnitsSold = 40, UnitPrice = 90 }
        };

        Console.WriteLine("📊 Revenue by Category and Top Product:");
        var revenueByCategory = sales
            .GroupBy(p => p.Category)
            .Select(g => new
            {
                Category = g.Key,
                TotalRevenue = g.Sum(p => p.UnitsSold * p.UnitPrice),
                TopProduct = g.OrderByDescending(p => p.UnitsSold).First().ProductName
            });

        foreach (var item in revenueByCategory)
        {
            Console.WriteLine($"Category: {item.Category} | Total Revenue: {item.TotalRevenue:C} | Top Product: {item.TopProduct}");
        }

        Console.WriteLine("\n🏆 Top 3 Products by Revenue:");
        var topProducts = sales
            .OrderByDescending(p => p.UnitsSold * p.UnitPrice)
            .Take(3);

        foreach (var product in topProducts)
        {
            decimal revenue = product.UnitsSold * product.UnitPrice;
            Console.WriteLine($"{product.ProductName} - Revenue: {revenue:C}");
        }

        Console.WriteLine("\n🔍 Products with Revenue > $1000:");
        var filtered = sales
            .Where(p => p.UnitsSold * p.UnitPrice > 1000)
            .OrderByDescending(p => p.UnitsSold * p.UnitPrice);

        foreach (var product in filtered)
        {
            decimal revenue = product.UnitsSold * product.UnitPrice;
            Console.WriteLine($"{product.ProductName} - Revenue: {revenue:C}");
        }
    }
}
