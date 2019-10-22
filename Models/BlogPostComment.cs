namespace WebAPIStarterData.Models
{
    public class BlogPostComment
    {
        public long BlogPostId { get; set;}
        public BlogPost BlogPost { get; set;}
        public long CommentId { get; set;}
        public Comment Comment { get; set;}
    }
}