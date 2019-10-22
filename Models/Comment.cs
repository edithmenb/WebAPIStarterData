using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIStarterData.Models
{
    public class Comment
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime Date { get; set; }
        // public int CommentTypeId { get; set; }
        // [ForeignKey("CommentTypeId")]
        // public CommentType CommentType { get; set; }
        // [ForeignKey("BlogPostId")]
        public BlogPost BlogPost { get; set;}
        public long BlogPostId { get; set; }
    }
}