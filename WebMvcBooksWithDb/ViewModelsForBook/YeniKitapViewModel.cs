using System.ComponentModel.DataAnnotations;

namespace WebMvcBooksWithDb.ViewModelsForBook
{
	public class YeniKitapViewModel: EditImageViewModel
	{
		[Required]
		public string KitapAdi { get; set; }
		[Required]
		public double Fiyat { get; set; }
		[Required]
		public int SayfaSayisi { get; set; }
		[Required]
		public int YayinlanmaTarihi { get; set; }
		[Required]
		public string KitapResmiUrl { get; set; }
	}
}
