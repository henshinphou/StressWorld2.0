using System.ComponentModel.DataAnnotations;

namespace StressWorld.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
