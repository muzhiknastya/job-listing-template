using ListingTemplate.Model;
using Microsoft.EntityFrameworkCore;

namespace ListingTemplate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<JobListing> JobListing { get; set; }
    }
}
