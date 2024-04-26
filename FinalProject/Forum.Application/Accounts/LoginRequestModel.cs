using System.ComponentModel.DataAnnotations;

namespace Forum.Application.Accounts
{
    public class LoginRequestModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberLogin { get; set; }
    }
}
