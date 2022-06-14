using Core.Entities;

namespace Entites.Concrete.Kullanici;

public class EntityKullanici : IEntity
{
    public int Id { get; set; }
    public int KullacniciCesitId { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public bool Aktif { get; set; }
}