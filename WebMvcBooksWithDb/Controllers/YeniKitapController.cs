using Microsoft.AspNetCore.Mvc;
using WebMvcBooksWithDb.Data;
using WebMvcBooksWithDb.Models;

namespace WebMvcBooksWithDb.Controllers
{
	public class YeniKitapController : Controller
	{
		public ApplicationDbContext _context;
		//constructor injection - dependency 
		public YeniKitapController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			List<YeniKitap> kitapListesi = new List<YeniKitap>();
			kitapListesi = _context.YeniKitap.ToList(); //select * from Kitap 
			return View(kitapListesi);
		}

		public IActionResult Details(int id)
		{
			YeniKitap kitapDetay;
			kitapDetay = _context.YeniKitap.Find(id); // select * from Kitap Where Id=id
													  //return View(_context.Kitap.Find(id));
			return View(kitapDetay);
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}
