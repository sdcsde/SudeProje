using SudeProje.Models;
using System.ComponentModel.DataAnnotations;

namespace SudeProje.Models
{
    public class Ders
    {
        [Key]
        public int DersID { get; set; }
        public string DersAd { get; set; }
        public string DersDetay { get; set; }
        public string DersOgretmen { get; set; }

        public IList<Kullanici> Kullanicis { get; set; }
        public IList<Uygulamali> Uygulamalis { get; set; }
    }
}
