using Core.Entities;

namespace Entites.Concrete.Tanim;

public class OdemeTur : IEntity
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}