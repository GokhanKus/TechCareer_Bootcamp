﻿using System.ComponentModel.DataAnnotations;

namespace WebMvcBooksWithDb.Models
{
	public class YeniKitap
	{
		//[Key]
		public int Id { get; set; }
		public string KitapAdi { get; set; }
		public double Fiyat { get; set; }
		public int SayfaSayisi { get; set; }
		public int YayinlanmaTarihi { get; set; }
		public string KitapResmi{ get; set; }
	}
}
