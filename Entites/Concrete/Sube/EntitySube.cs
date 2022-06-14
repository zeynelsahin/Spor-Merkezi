using Core.Entities;

namespace Entites.Concrete.Sube;

public class EntitySube : IEntity
{
    public int Id { get; set; }
    public int Ilce { get; set; }
    public string Ad { get; set; }
    public string Adres { get; set; }
    public string Telefon { get; set; }
    public string EPosta { get; set; }
    public bool BayanlaraOzel { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}