using System.ComponentModel.DataAnnotations;

namespace WebMvcBooksWithDb.Models
{
	public class YeniKitap
	{
		//[Key]
		public int Id { get; set; }
		[Required]
		public string KitapAdi { get; set; }
		[Required]
		public double Fiyat { get; set; }
		[Required]
		public int SayfaSayisi { get; set; }
		[Required]
		public int YayinlanmaTarihi { get; set; }
		[Required]
		public string KitapResmi{ get; set; }
	}
}
