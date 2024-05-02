using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebMvcBooks.Models;

namespace WebMvcBooks.Controllers
{
	public class BooksController : Controller
	{
		//WebApiBooks projemiz bu url uzerinden calisiyor: http://localhost:25917/api/Books ve apideki verileri sayfamizda goruntuleyelim
		private string booksUrl = "http://localhost:25917/api/Books";
		private string rootUrl = "http://localhost:25917/";
		public async Task<IActionResult> GetAllBooks()
		{
			var books = new List<Book>();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync(booksUrl)) //parametre olarak verilen uri'ye get requesti atar, yani bu satırdan sonra calismakta olan apideki GetAllBooks() metoduna gider, o da veri tabanindan verileri getirir
				{
					string jsonBooks = await response.Content.ReadAsStringAsync(); //
					books = JsonConvert.DeserializeObject<List<Book>>(jsonBooks);
					//books = JsonSerializer.Deserialize<List<Book>>(apiResponse); //using System.Text.Json;
				}
			}
			return View(books); //sag click ile add view diyip razor view ile otomatik viewi olusturalim
		}

		[HttpGet]
		public async Task<IActionResult> GetBook(int id)
		{
			var book = new Book();
			using (var httpClient = new HttpClient())
			{
				//using (var response = await httpClient.GetAsync($"{booksUrl}/{id}")) //boyle de yazilabilir
				//{
				//	string jsonBook = await response.Content.ReadAsStringAsync();
				//	book = JsonConvert.DeserializeObject<Book>(jsonBook);
				//}
				book = await httpClient.GetFromJsonAsync($"{booksUrl}/{id}", typeof(Book)) as Book; //kisa yazim sekli GetFromJsonAsync() asp.net core 5.0'dan sonra kullanima sunuldu
			}
			return View(book);
		}

		//tiklanilan kitabi api aracigiliyla sayfaya getiriyoruz
		public async Task<IActionResult> EditBook(int id)
		{
			var book = new Book();
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync($"{booksUrl}/{id}")) //apideki GetBook()metoduna gider o da db'den o id'ye sahip kitabi bulur getirir
				{
					string jsonBook = await response.Content.ReadAsStringAsync();
					book = JsonConvert.DeserializeObject<Book>(jsonBook);
				}
			}
			return View(book);
		}

		//ve guncelleme islemini api'ye gonderiyoruz api'de guncelleniyor.
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
				var response = await httpClient.PutAsJsonAsync("api/books", guncellenecekKitap); //put requesti gonderir ve json olarak serilize edilir, api'ye gider, UpdateBook() metoduna gider

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

		public ViewResult CreateBook() => View();

		[HttpPost]
		public async Task<IActionResult> CreateBook(Book book) //sag tik add view diyerek sayfanin iskeletini otomatik olustursun
		{
			using (var httpClient = new HttpClient())
			{
				//StringContent bookToJson = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
				var response = await httpClient.PostAsJsonAsync(booksUrl, book);//apiye post istegi atar ve degeri json olarak serilize eder, apideki CreateBook() metoduna gider
				if (response.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "Books");
				}
				else
				{
					return NotFound();
				}
			}
		}
	}
}
