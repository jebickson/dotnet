using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;

public class ProfileUploadModel : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "Name is required.")]
    public string UserName { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Please upload a profile picture.")]
    [DataType(DataType.Upload)]
    public IFormFile ProfilePicture { get; set; }

    public string Message { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
        Directory.CreateDirectory(uploadsFolder); // Ensure folder exists

        var filePath = Path.Combine(uploadsFolder, ProfilePicture.FileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await ProfilePicture.CopyToAsync(stream);
        }

        Message = $"Thank you, {UserName}. Your profile picture has been uploaded.";
        return Page();
    }
}
