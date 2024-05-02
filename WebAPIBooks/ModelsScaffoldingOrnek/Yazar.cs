using System;
using System.Collections.Generic;

namespace WebAPIBooks.Models;

public partial class Yazar
{
    public int Id { get; set; }

    public string? YazarAdi { get; set; }

    public string? YazarSoyadi { get; set; }
}
