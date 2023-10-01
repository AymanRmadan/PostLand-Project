using System.ComponentModel.DataAnnotations;

namespace PostLand.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Blogs { get; set; }
    }

}
