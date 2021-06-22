using Core.Entities;

public class KazanDoldurmaOperasyonlari_MateryalIcerikleri:IEntity
{
    public int Id { get; set; }
    public int MateryalIcerikID { get; set; }
    public int KazanDoldurmaOperasyonlariID { get; set; }
}