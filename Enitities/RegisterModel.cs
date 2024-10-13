using System.ComponentModel.DataAnnotations;

namespace haziDolgozat2024._10._13.Enitities
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
