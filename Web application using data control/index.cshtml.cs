using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class EmployeeListModel : PageModel
{
    public List<Employee> Employees { get; set; }

    public void OnGet()
    {
        // Simulate data from a database
        Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Department = "HR", Email = "alice@company.com" },
            new Employee { Id = 2, Name = "Bob Smith", Department = "IT", Email = "bob@company.com" },
            new Employee { Id = 3, Name = "Charlie Lee", Department = "Finance", Email = "charlie@company.com" }
        };
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
}
