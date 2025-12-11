using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

public class CountrySelectorModel : PageModel
{
    [BindProperty]
    public string SelectedCountry { get; set; }

    public List<SelectListItem> CountryList { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
        LoadCountries();
    }

    public void OnPost()
    {
        LoadCountries();

        if (!string.IsNullOrEmpty(SelectedCountry))
        {
            Message = $"You selected: {SelectedCountry}";
        }
        else
        {
            Message = "Please select a country.";
        }
    }

    private void LoadCountries()
    {
        CountryList = new List<SelectListItem>
        {
            new SelectListItem { Value = "India", Text = "India" },
            new SelectListItem { Value = "USA", Text = "United States" },
            new SelectListItem { Value = "UK", Text = "United Kingdom" },
            new SelectListItem { Value = "Germany", Text = "Germany" },
            new SelectListItem { Value = "Japan", Text = "Japan" }
        };
    }
}
