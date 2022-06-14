using Core.Entities;

namespace Entites.Concrete.Kullanici;

public class KullaniciGiris : IEntity
{
    public int Id { get; set; }
    public int KullaniciId { get; set; }
    public int KapiId { get; set; }
    public DateTime GirisTarihi { get; set; }
}