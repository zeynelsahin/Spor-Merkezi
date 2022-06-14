using Core.Entities;

namespace Entites.Concrete.Tanim;

public class VucutOlcu : IEntity
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Birim { get; set; }
    public bool SilmeDurumu { get; set; }
}