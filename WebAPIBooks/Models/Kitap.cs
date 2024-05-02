using System;
using System.Collections.Generic;

namespace WebAPIBooks.Models;

public partial class Kitap
{
    public int Id { get; set; }

    public string? KitapAdi { get; set; }

    public decimal? Fiyat { get; set; }

    public int? SayfaSayisi { get; set; }

    public int? YazarId { get; set; }

    public int? KategoriId { get; set; }

    public int? YayineviId { get; set; }
}
