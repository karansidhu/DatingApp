using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDtos
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Password should be between 4 & 8 characters")]
        public string Password { get; set; }
    }
}