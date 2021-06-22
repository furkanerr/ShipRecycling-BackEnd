using System;
using Core.Entities;

public class BlokDetailDto:IDto
{
    public int ID { get; set; }

    public int IcerikYuzdeleri { get; set; }
    public DateTime GemidenKesimBalangicTarihi { get; set; }
    public string  GemidekiKesimci { get; set; }
    public string  MadenAyriştirmaci { get; set; }
    public DateTime GemidenKesimBitisTarihi { get; set; }

    public int GemidenKesimSuresi { get; set; }
    public DateTime BlogunSahayaGelisTarihi { get; set; }


    public DateTime SahadakiKesimBaslangicTarihi { get; set; }

    public int SahadakiKesimSuresi { get; set; }
    public DateTime SahadakiKesimBitisTarihi { get; set; }

    public DateTime MadenAyristirmaBaslangicTarihi { get; set; }

    public int MadenAyristirmaSuresi { get; set; }
    public DateTime MadenAyristirmaBitisTarihi { get; set; }
}