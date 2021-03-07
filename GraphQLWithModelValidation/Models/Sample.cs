using System.ComponentModel.DataAnnotations;

namespace GraphQLWithModelValidation.Models
{
    public class Sample
    {
        [Required]
        public int Count { get; set; }

        [Required]
        [MinLength(3)]
        public string Text { get; set; } = string.Empty;
    }
}
