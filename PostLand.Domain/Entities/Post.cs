using System.ComponentModel.DataAnnotations;

namespace PostLand.Domain.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
    }

}
