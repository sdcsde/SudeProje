using Microsoft.AspNetCore.Mvc;

namespace SudeProje.Controllers
{
	public class HakkimizdaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
