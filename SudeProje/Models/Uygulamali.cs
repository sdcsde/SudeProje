using System.ComponentModel.DataAnnotations;

namespace SudeProje.Models
{
    public class Uygulamali
    {
        [Key]
        public int UygulamaliID { get; set; }
        public string UygulamaliAd { get; set; }
        public string UygulamaliDetay { get; set; }
        public string UygulamaliOgretmen { get; set; }
        public int DersID { get; set; }

        public Ders Ders { get; set; }
    }
}
