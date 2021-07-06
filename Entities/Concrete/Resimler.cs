using Core.Entities;

public class Resimler : IEntity
{
    public int Id { get; set; }

    public int GemiId { get; set; }
    public string ResimAdresi { get; set; }
}