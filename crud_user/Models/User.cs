using System.ComponentModel.DataAnnotations;

namespace crud_user.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3,ErrorMessage ="Min Length is 3")]
        [MaxLength(10,ErrorMessage ="Max Length is 10")]
        public string Name { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Max Length is 15")]
        public string City { get; set; }
        public int? Age { get; set; }

    }
}
