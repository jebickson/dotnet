using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class WebExposureModel : PageModel
{
    [BindProperty]
    public string UserName { get; set; }

    [BindProperty]
    public int Age { get; set; }

    [BindProperty]
    public string Course { get; set; }

    public string Message { get; set; }

    public void OnGet()
    {
        // Runs when page loads
    }

    public void OnPost()
    {
        Message = $"Welcome {UserName}! You are {Age} years old and enrolled in {Course}.";
    }
}