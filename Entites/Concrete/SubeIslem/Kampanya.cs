using Core.Entities;

namespace Entites.Concrete.SubeIslem;

public class Kampanya : IEntity
{
    public int Id { get; set; }
    public string Aciklama { get; set; }
    public int Tutar { get; set; }
    public int Oran { get; set; }
    public DateTime GecerlilikTarihi { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}