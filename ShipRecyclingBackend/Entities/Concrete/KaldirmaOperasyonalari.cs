using Core.Entities;

public class KaldirmaOperasyonalari:IEntity

{
    public int Id { get; set; }
    public int GemiID { get; set; }  
    public int BlokID { get; set; }
    public int VincOperatoruID { get; set; }  
    public int Isaretci_SapanciD { get; set; }
    public int KaldirmaOperasyonuPlanNo { get; set; }  
    public int Dengelimi { get; set; }
    public int Uygunmu { get; set; }  

    public int Tonaj { get; set; }  
    public int TasimaSuresi { get; set; }
    public int SapanSayisi { get; set; }  
}