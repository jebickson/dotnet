using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string UserName { get; set; }

    public string GreetingMessage { get; set; }

    public void OnGet()
    {
        // Initial load, nothing to do
    }

    public void OnPost()
    {
        if (!string.IsNullOrWhiteSpace(UserName))
        {
            GreetingMessage = $"Hello, {UserName}! Welcome to our site.";
        }
        else
        {
            GreetingMessage = "Please enter your name.";
        }
    }
}
