using Core.Entities;

namespace Entites.Concrete.SubeIslem;

public class Tahsilat : IEntity
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public int OdemeTuruId { get; set; }
    public int KullaniciId { get; set; }
    public DateTime Tarih { get; set; }
    public decimal Tutar { get; set; }
    public bool SilmeDurumu { get; set; }
}