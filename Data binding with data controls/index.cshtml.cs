using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class ProductListModel : PageModel
{
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        // Simulate data from a database
        Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 899.99 },
            new Product { Id = 2, Name = "Desk Chair", Category = "Furniture", Price = 129.50 },
            new Product { Id = 3, Name = "Notebook", Category = "Stationery", Price = 3.75 },
            new Product { Id = 4, Name = "Headphones", Category = "Electronics", Price = 59.99 }
        };
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}
