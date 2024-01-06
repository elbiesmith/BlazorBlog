using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorBlog.Shared.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Display(Name = "Blog Name")]
        public int BlogId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Post Title")]
        public required string Title { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 2)]
        public required string Abstract { get; set; }

        [Required]
        public required string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }

        public string? Slug { get; set; }

        public string? ImageType { get; set; }

        [Display(Name = "Post Image")]
        public byte[]? ImageData { get; set; }

        [Display(Name = "Are you ready to Post?")]
        public bool IsReady { get; set; }

        [NotMapped]
        [Display(Name = "Select Image")]
        public IFormFile? Image { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
        public virtual Blog? Blog { get; set; }
    }
}