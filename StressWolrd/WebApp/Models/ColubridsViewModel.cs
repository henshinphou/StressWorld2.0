using Microsoft.Build.Framework;

namespace WebApp.Models
{
    public class ColubridsViewModel
    {
        public int Id { get; set; }
        [Required]
        public string? Spicies { get; set; }
        [Required]
        public string? Morph { get; set; }
        [Required]
        public string? ImportFrom { get; set; }
        public int ImportPrice { get; set; }
        public int SellPrice { get; set; }
        public string? Sex { get; set; }
        public string? Size { get; set; }
        public bool Status { get; set; }
        public int CustomerPhone { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerLocation { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime SellDate { get; set; }

    }
}
