using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

public class LanguageSelectorModel : PageModel
{
    [BindProperty]
    public List<string> SelectedLanguages { get; set; }

    public List<SelectListItem> LanguageOptions { get; set; }

    public void OnGet()
    {
        LoadLanguages();
    }

    public void OnPost()
    {
        LoadLanguages();
        // SelectedLanguages will be automatically bound from the form
    }

    private void LoadLanguages()
    {
        LanguageOptions = new List<SelectListItem>
        {
            new SelectListItem { Value = "C#", Text = "C#" },
            new SelectListItem { Value = "Java", Text = "Java" },
            new SelectListItem { Value = "Python", Text = "Python" },
            new SelectListItem { Value = "JavaScript", Text = "JavaScript" },
            new SelectListItem { Value = "Go", Text = "Go" }
        };
    }
} 
