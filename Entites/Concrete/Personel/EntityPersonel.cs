using Core.Entities;

namespace Entites.Concrete.Personel;

public class EntityPersonel : IEntity
{
    public int Id { get; set; }
    public int SubeId { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public decimal Maas { get; set; }
    public string Telefon { get; set; }
    public string EPosta { get; set; }
}