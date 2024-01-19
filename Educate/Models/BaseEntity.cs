using System.ComponentModel.DataAnnotations;

namespace Educate.Models
{
    public class BaseEntity
    {
        [Required(ErrorMessage = "Write a Title"), 
            MinLength(5, ErrorMessage = "Text can't be less than 5 letters"), 
            MaxLength(20, ErrorMessage = "Text can't be longer than 20 letters")]
        public string Title { get; set; }
    }
}
