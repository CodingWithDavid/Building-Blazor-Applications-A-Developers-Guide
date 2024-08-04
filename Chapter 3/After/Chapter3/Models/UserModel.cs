using Chapter3.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Chapter3.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 120, ErrorMessage = "Please enter a valid age between 1 and 120.")]
        public int Age { get; set; }

        [CustomValidator(ErrorMessage = "Custom validation failed")]
        [Required(ErrorMessage = "Custom Value is required.")]
        public string CustomizeValue { get; set; } = string.Empty;
    }
}
