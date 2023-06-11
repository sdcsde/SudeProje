using System.ComponentModel.DataAnnotations;

namespace SudeProje.Models
{
    public class Sertfika
    {
        [Key]
        public int SertfikaID { get; set; }
        public string SertfikaAd { get; set; }
        public DateTime VerilisTarih { get; set; }
    }
}
