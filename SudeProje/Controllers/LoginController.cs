using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SudeProje.Models;
using System.Security.Claims;

namespace SudeProje.Controllers
{
	public class LoginController : Controller
	{
		Context c = new Context();
		[HttpGet]
		public IActionResult GirisYap()
		{
			return View();
		}
		public async Task<IActionResult> GirisYap(Admin p)
		{
			var bilgiler = c.Admins.FirstOrDefault(x => x.Mail == p.Mail && x.Sifre == p.Sifre);
			if (bilgiler != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.Mail)
				};
				var useridentity = new ClaimsIdentity(claims, "Login");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Kullanicim");
			}
			return View();
		}

	}
}
