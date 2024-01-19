using System.ComponentModel.DataAnnotations;

namespace Educate.Models
{
    public class Instructor : BaseEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "It must have an image")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Write a person's name"), MinLength(2), MaxLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Write about a person"), MinLength(5), MaxLength(25)]
        public string About { get; set; }

    }
}
