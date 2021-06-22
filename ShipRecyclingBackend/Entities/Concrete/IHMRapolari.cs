using System;
using Core.Entities;

public class IHMRapolari:IEntity
{
    public int Id { get; set; }
    public int GemiID { get; set; }
    public DateTime MarkalamaTarihi { get; set; }
}