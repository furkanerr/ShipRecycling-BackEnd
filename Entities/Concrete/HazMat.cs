using System;
using Core.Entities;

public class HazMat : IEntity
{
    public int Id { get; set; }
    public int IHMRaporID { get; set; }
    public int BlokID { get; set; }
    public int OlcuBirimiID { get; set; }
    public int GemiID { get; set; }
    public int Miktar { get; set; }
    public DateTime MarkalamaTarihi { get; set; }

    public int HazMatTipID { get; set; }
    
}