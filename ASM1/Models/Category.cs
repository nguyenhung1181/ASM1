using System.ComponentModel.DataAnnotations;

namespace ASM1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string? Name { get; set; }
    }
}
