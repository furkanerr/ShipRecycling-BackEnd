using System;
using Core.Entities;

public class Malzemeler : IEntity
{
    public int Id { get; set; }

    public int OlcuBirimiID { get; set; }
    public int GemiID { get; set; }

    public int ParaBirimiID { get; set; }
    public string MateryalAdi { get; set; }

    public string Miktar { get; set; }
    public string Lokasyon { get; set; }

    public string KayitTarihi { get; set; }

    public DateTime SatisTarihi { get; set; }
    public int Fiyat { get; set; }

    public int UseOrSale { get; set; }
}