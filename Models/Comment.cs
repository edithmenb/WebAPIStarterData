using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIStarterData.Models
{
    public class Comment
    {
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}