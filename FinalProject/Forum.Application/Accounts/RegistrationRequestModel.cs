using System.ComponentModel.DataAnnotations;

namespace Forum.Application.Accounts
{
    public class RegistrationRequestModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}