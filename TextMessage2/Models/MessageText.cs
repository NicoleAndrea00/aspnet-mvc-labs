using System.ComponentModel.DataAnnotations;

namespace TextMessage.Models
{
    public class MessageText
    {
        [Required]
        [StringLength(10, MinimumLength =10, ErrorMessage ="Phone Number must be exactly 10 digits long")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone Number must be 10 Digits Long.")]
        [Display(Name ="Phone Number")]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(140, ErrorMessage="Message exceeded length of 140 Characters")]
        [Display(Name ="Your Message")]
        public string Content { get; set; }
    }
}
