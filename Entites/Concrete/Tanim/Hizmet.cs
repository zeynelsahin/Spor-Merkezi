using Core.Entities;

namespace Entites.Concrete.Tanim;

public class Hizmet : IEntity
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public bool Durum { get; set; }
}