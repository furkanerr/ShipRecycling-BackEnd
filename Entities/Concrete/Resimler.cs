using Core.Entities;

public class Resimler : IEntity
{
    public int Id { get; set; }

    public int BlokId { get; set; }
    public string ResimAdresi { get; set; }
}