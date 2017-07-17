namespace Twee.Api.Models
{
    public class Post : AuditModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
