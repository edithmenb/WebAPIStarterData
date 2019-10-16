using System.ComponentModel.DataAnnotations;

namespace WebAPIStarterData.Models
{
    public class BlogPost
    {
        public long Id { get; set; }
        [Required]
        public string Title { get; set;}
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
    }
}