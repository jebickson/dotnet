using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

public class DepartmentSelectorModel : PageModel
{
    [BindProperty]
    public string SelectedDepartment { get; set; }

    public List<SelectListItem> DepartmentList { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
        LoadDepartments();
    }

    public void OnPost()
    {
        LoadDepartments();

        if (!string.IsNullOrEmpty(SelectedDepartment))
        {
            Message = $"You selected the {SelectedDepartment} department.";
        }
        else
        {
            Message = "Please select a department.";
        }
    }

    private void LoadDepartments()
    {
        DepartmentList = new List<SelectListItem>
        {
            new SelectListItem { Value = "HR", Text = "Human Resources" },
            new SelectListItem { Value = "IT", Text = "Information Technology" },
            new SelectListItem { Value = "FIN", Text = "Finance" },
            new SelectListItem { Value = "MKT", Text = "Marketing" }
        };
    }
}
