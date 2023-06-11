using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SudeProje.Models;

namespace SudeProje.Controllers
{
    public class KullanicimController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Kullanicis.Include(x => x.Ders).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniKullanici()
        {
            List<SelectListItem> degerler = (from x in c.Derss.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DersAd,
                                                 Value = x.DersID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        public IActionResult YeniKullanici(Kullanici p)
        {
            var per = c.Derss.Where(x => x.DersID == p.Ders.DersID).FirstOrDefault();
            p.Ders = per;
            c.Kullanicis.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KullaniciSil(int id)
        {
            var dep = c.Kullanicis.Find(id);
            c.Kullanicis.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult KullaniciGetir(int id)
        {
            var klln = c.Kullanicis.Find(id);
            return View("KullanicilGetir", klln);
        }
        public IActionResult KullaniciGuncelle(Kullanici d)
        {
            var dep = c.Kullanicis.Find(d.KullaniciID);
            dep.KullaniciAd = d.KullaniciAd;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
