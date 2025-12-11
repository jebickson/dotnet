using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

public class ColorPickerModel : PageModel
{
    [BindProperty]
    public string FavoriteColor { get; set; }

    public List<SelectListItem> ColorOptions { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
        LoadColorOptions();
    }

    public void OnPost()
    {
        LoadColorOptions();

        if (!string.IsNullOrEmpty(FavoriteColor))
        {
            Message = $"You selected: {FavoriteColor}";
        }
        else
        {
            Message = "Please select a color.";
        }
    }

    private void LoadColorOptions()
    {
        ColorOptions = new List<SelectListItem>
        {
            new SelectListItem { Value = "Red", Text = "Red" },
            new SelectListItem { Value = "Green", Text = "Green" },
            new SelectListItem { Value = "Blue", Text = "Blue" }
        };
    }
}
