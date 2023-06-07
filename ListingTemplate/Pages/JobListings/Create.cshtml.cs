using ListingTemplate.Data;
using ListingTemplate.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListingTemplate.Pages.JobListings
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public JobListing JobListing { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (JobListing.Description.Length < 200) 
            {
                ModelState.AddModelError(string.Empty, "The description must be at least 200 character long.");
            }
            if (ModelState.IsValid) 
            {
                await _db.JobListing.AddAsync(JobListing);
                await _db.SaveChangesAsync();
                TempData["success"] = "Your Advertisement has been posted.";
                return RedirectToPage("Index");
            }
            return Page();            
        }
    }
}
