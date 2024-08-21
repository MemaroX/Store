using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = "";
        [Required, MaxLength(1000)]
        public string Description { get; set; }
        = "";
        [Required,MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required, MaxLength(100)]
        public string Category { get; set; } = "";
        [Required]
        public decimal Price { get; set; }
        public IFormFile? Imagefile { get; set; }
    }
}
