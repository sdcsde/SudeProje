using SudeProje.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SudeProje.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string Nickname { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }
        public IList<Sertfika> Sertfikas { get; set; }
    }
}
