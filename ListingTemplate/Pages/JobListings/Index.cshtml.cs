using ListingTemplate.Data;
using ListingTemplate.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace ListingTemplate.Pages.JobListings
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;
        public IEnumerable<JobListing> JobListings { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            JobListings = _db.JobListing;
        }
    }
}
