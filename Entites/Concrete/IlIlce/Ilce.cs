using Core.Entities;

namespace Entites.Concrete;

public class Ilce : IEntity
{
    public int id { get; set; }
    public string IlceAdi { get; set; }
    public int SehirId { get; set; }
}