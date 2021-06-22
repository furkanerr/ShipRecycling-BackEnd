using Core.Entities;

public class Gemiler : IEntity
{
    public int Id { get; set; }

    public int GemiTipiID { get; set; }
    public int BayrakID { get; set; }

    public int Tonnage { get; set; }
    public int IMONo { get; set; }
   
    public string GemiSahibiSirket { get; set; }
}