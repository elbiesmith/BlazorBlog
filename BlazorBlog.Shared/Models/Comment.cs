using BlazorBlog.Data;
using BlazorBlog.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlazorBlog.Shared.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }

        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Updated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Moderated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Deleted { get; set; }

        [Display(Name = "Moderated Comment")]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 1)]
        public string ModeratedBody { get; set; }

        public ModerationType ModerationReason { get; set; }

        [Required]
        [Display(Name = "Comment")]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 1)]
        public string Body { get; set; }

        public virtual Post Post { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual ApplicationUser Moderator { get; set; }
    }
}