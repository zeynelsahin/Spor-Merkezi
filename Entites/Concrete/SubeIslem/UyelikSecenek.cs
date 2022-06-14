using Core.Entities;

namespace Entites.Concrete.SubeIslem;

public class UyelikSecenek : IEntity
{
    public int Id { get; set; }
    public int SubeId { get; set; }
    public string Sure { get; set; }
    public decimal Fiyat { get; set; }
    public decimal MinFiyat { get; set; }
    public string Ad { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}