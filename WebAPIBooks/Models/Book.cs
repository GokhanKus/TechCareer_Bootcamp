using System.ComponentModel.DataAnnotations;

namespace WebAPIBooks.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string KitapAdi { get; set; }
        [Required]
        public double Fiyat { get; set; }
        [Required]
        public int SayfaSayisi { get; set; }
    }
}
