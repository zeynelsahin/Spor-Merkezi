using Core.Entities;

namespace Entites.Concrete;

public class Egitmen : IEntity
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
}