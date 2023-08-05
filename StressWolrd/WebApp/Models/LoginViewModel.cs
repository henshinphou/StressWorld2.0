using Microsoft.Build.Framework;

namespace WebApp.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
