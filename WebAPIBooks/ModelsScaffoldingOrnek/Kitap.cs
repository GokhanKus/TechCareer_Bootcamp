using System;
using System.Collections.Generic;

namespace WebAPIBooks.Models;

public partial class Kitap
{
    public int Id { get; set; }

    public string? KitapAdi { get; set; }

    public decimal? Fiyat { get; set; }

    public int? SayfaSayisi { get; set; }

    // scaffolding yaparken -otomatik olustururken dbcontext ve modelleri one to many icin sadece foreign key atadı, navigation propları olusturmamisti, duzenlendi.
    public int? YazarId { get; set; }
    public Yazar Yazar { get; set; }

    public int? KategoriId { get; set; }
    public Kategori Kategori { get; set; }

    public int? YayineviId { get; set; }
    public Yayinevi Yayinevi { get; set; }
}
