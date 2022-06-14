using Core.Entities;

namespace Entites.Concrete.Uye;

public class Not : IEntity
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public int KullaniciId { get; set; }
    public string Metin { get; set; }
    public DateTime TarihSaat { get; set; }
}