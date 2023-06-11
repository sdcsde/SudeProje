
using Microsoft.AspNetCore.Mvc;
using SudeProje.Models;

namespace CoreProje.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Derss.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDers(Ders b)
        {
            c.Derss.Add(b); c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DersSil(int id)
        {
            var dep = c.Derss.Find(id);
            c.Derss.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DersGetir(int id)
        {
            var drs = c.Derss.Find(id);
            return View("DersGetir", drs);
        }
        public IActionResult DersGuncelle(Ders d)
        {
            var dep = c.Derss.Find(d.DersID);
            dep.DersAd = d.DersAd;
            dep.DersOgretmen = d.DersOgretmen;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DersDetay(int id)
        {
            var degerler = c.Kullanicis.Where(x => x.DersID == id).ToList();
            var drsad = c.Derss.Where(x => x.DersID == id).Select(y => y.DersAd).FirstOrDefault();
            ViewBag.drs = drsad;
            return View(degerler);
        }
    }
}
