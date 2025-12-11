using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

public class StudentsModel : PageModel
{
    // Simulated database
    public static List<Student> StudentDb = new List<Student>();
    private static int nextId = 1;

    [BindProperty]
    public Student Student { get; set; } = new Student();

    public List<Student> Students => StudentDb;

    public void OnGet() { }

    public IActionResult OnPostSave()
    {
        if (Student.Id == 0)
        {
            // Insert
            Student.Id = nextId++;
            StudentDb.Add(Student);
        }
        else
        {
            // Update
            var existing = StudentDb.FirstOrDefault(s => s.Id == Student.Id);
            if (existing != null)
            {
                existing.Name = Student.Name;
                existing.Age = Student.Age;
            }
        }

        return RedirectToPage();
    }

    public IActionResult OnPostEdit(int id)
    {
        var student = StudentDb.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            Student = new Student
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age
            };
        }
        return Page();
    }

    public IActionResult OnPostDelete(int id)
    {
        var student = StudentDb.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
            StudentDb.Remove(student);
        }
        return RedirectToPage();
    }

    public IActionResult OnPostCancel()
    {
        return RedirectToPage();
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
