using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebMvcBooks.Models;

namespace WebMvcBooks.Controllers
{
    public class BooksController : Controller
    {
        //WebApiBooks projemiz bu url uzerinden calisiyor: http://localhost:25917/api/Books ve apideki verileri sayfamizda goruntuleyelim
        private string booksUrl = "http://localhost:25917/api/Books";
        private string rootUrl = "http://localhost:25917/";
        public async Task<IActionResult> Index()
        {
            var books = new List<Book>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(booksUrl))
                {
                    string jsonBooks = await response.Content.ReadAsStringAsync();
                    books = JsonConvert.DeserializeObject<List<Book>>(jsonBooks);
                }
            }
            return View(books); //sag click ile add view diyip razor view ile otomatik viewi olusturalim
        }
        public async Task<IActionResult> EditBook(int id)
        {
            var book = new Book();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{booksUrl}/{id}"))
                {
                    string jsonBook = await response.Content.ReadAsStringAsync();
                    book = JsonConvert.DeserializeObject<Book>(jsonBook);
                }
            }
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> EditBook(Book book)
        {
            var guncellenecekKitap = new Book();
            using (var httpClient = new HttpClient())
            {
                guncellenecekKitap = new Book
                {
                    Id = book.Id,
                    Fiyat = book.Fiyat,
                    KitapAdi = book.KitapAdi,
                    SayfaSayisi = book.SayfaSayisi,
                };
                //string jsonBook = JsonConvert.SerializeObject(guncellenecekKitap);
                httpClient.BaseAddress = new Uri(rootUrl);
                var response = await httpClient.PutAsJsonAsync("api/books", guncellenecekKitap);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Books");
                }
                else
                {
                    return View();
                }
            }
        }
    }
}
