using Core.Entities;

namespace Entites.Concrete.Personel;

public class PersonelKart : IEntity
{
    public int PersonelId { get; set; }
    public string KartNo { get; set; }
}