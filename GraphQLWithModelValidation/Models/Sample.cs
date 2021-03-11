using System.ComponentModel.DataAnnotations;

namespace GraphQLWithModelValidation.Models
{
    public class Sample
    {
        [Required]
        [Range(0, 10)]
        public int Count { get; set; }

        [Required]
        [MinLength(3)]
        public string Text { get; set; } = string.Empty;
    }
}
