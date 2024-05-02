using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebMvcBooks.Models;
using static System.Net.WebRequestMethods;

namespace WebMvcBooks.Controllers
{
    public class BooksController : Controller
    {
        //WebApiBooks projemiz bu url uzerinden calisiyor: http://localhost:25917/api/Books ve apideki verileri sayfamizda goruntuleyelim
        private string url = "http://localhost:25917/api/Books";
        public async Task<IActionResult> Index()
        {
            var books = new List<Book>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    books = JsonConvert.DeserializeObject<List<Book>>(apiResponse);
                }
            }
            return View(books); //sag click ile add view diyip razor view ile otomatik viewi olusturalim
        }
    }
}
