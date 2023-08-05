using System.ComponentModel.DataAnnotations;

namespace StressWorld.Models
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
        public string? Status { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerLocation { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime SellDate { get; set; }
        public static ColubridsViewModel FromCsv(string csvLine)
        {
            ColubridsViewModel colubrid = new ColubridsViewModel();

            if (!string.IsNullOrEmpty(csvLine)) {
                string[] values = csvLine.Split(',');
                colubrid.Spicies = values[0];
                colubrid.Morph = values[1];
                colubrid.ImportFrom = values[2];
                colubrid.ImportPrice = Int32.Parse(values[3]);
                colubrid.SellPrice = Int32.Parse(values[4]);
                colubrid.Sex = values[5];
                colubrid.Size = values[6];
                colubrid.Status = values[7];
                colubrid.CustomerPhone = values[8];
                colubrid.CustomerName = values[9];
                colubrid.CustomerLocation = values[10];
                colubrid.ImportDate = DateTime.Parse(values[11]);
                colubrid.SellDate = DateTime.Parse(values[12]);
            }
            return colubrid;
        }

    }
}
