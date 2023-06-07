using System.ComponentModel.DataAnnotations;

namespace ListingTemplate.Model
{
    public class JobListing
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public JobListing()
        {
            Author = "Unknown";
            Created = DateTime.Now;
        }

    }
}
