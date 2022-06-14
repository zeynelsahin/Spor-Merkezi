using Core.Entities;

namespace Entites.Concrete.Uye;

public class UyeIletisim : IEntity
{
    public int Id { get; set; }
    public string Telefon { get; set; }
    public string Telefon2 { get; set; }
    public string EPosta { get; set; }
}