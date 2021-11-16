using System.ComponentModel.DataAnnotations;

namespace PostMaker.Models
{
    public class CreatePostViewModel
    {
        [Required]
        public string Author { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public CreatePostViewModel()
        {
            Created = DateTime.Now;         
        }
    }
}
