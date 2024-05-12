using System.ComponentModel.DataAnnotations;

namespace APPBlog1.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishedOn { get; set; }

        public bool Archived { get; set; }


        public int BlogId { get; set; }

        public Blog? Blog { get; set; }
    }
}
