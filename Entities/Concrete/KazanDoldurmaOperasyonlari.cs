using Core.Entities;

public class KazanDoldurmaOPerasyonlari:IEntity
{
    public int Id{ get; set; }
    public int HazMatID { get; set; }
    public int KazanID { get; set; }
    public int MateryalID{ get; set; }
    public int AhsapciID { get; set; }
    public int MadenAyristirmaciID { get; set; }
    public int MadenAyristirmaSuresi{ get; set; }
    public int IcerikYuzdeleri { get; set; }
}