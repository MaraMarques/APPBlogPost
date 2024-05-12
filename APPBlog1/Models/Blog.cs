using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace APPBlog1.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Uri SiteUri { get; set; }


        public ICollection<Post>? Posts { get; }
    }
}
