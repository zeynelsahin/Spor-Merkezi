using Core.Entities;

namespace Entites.Concrete.Personel;

public class PersonelGiris : IEntity
{
    public int Id { get; set; }
    public int KartNo { get; set; }
    public int KapiId { get; set; }
    public DateTime GirisTarihi { get; set; }
}