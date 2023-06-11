using Microsoft.AspNetCore.Mvc;
using SudeProje.Models;

namespace SudeProje.Controllers
{
    public class UygulamalidrsController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Uygulamalis.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniUygulamalidrs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUygulamalidrs(Uygulamali b)
        {
            c.Uygulamalis.Add(b); 
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UygulamalidrsSil(int id)
        {
            var dep = c.Uygulamalis.Find(id);
            c.Uygulamalis.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UygulamalidrsGetir(int id)
        {
            var drs = c.Uygulamalis.Find(id);
            return View("UygulamalidrsGetir", drs);
        }
        public IActionResult UygulamalidrsGuncelle(Uygulamali d)
        {
            var dep = c.Uygulamalis.Find(d.UygulamaliID);
            dep.UygulamaliAd = d.UygulamaliAd;
            dep.UygulamaliOgretmen = d.UygulamaliOgretmen;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
