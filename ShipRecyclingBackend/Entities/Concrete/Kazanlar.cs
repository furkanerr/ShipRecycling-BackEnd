using System;
using Core.Entities;

public class Kazanlar:IEntity
{
    public int  ID { get; set; }
    public int  Agirlik { get; set; }
    public int  SafeWorkingLoad { get; set; }
    public int  PeriyordikKontrolBirimDegeri { get; set; }
    public int  PeriyodikKontrolBirimi { get; set; }
    public DateTime  SonKontrolTarihi { get; set; }
    public DateTime  UretimTarihi { get; set; }

    
}