using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
        public string Text { get; set; }

        //Navs
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}