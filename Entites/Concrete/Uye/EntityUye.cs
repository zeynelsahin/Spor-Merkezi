using Core.Entities;

namespace Entites.Concrete.Uye;

public class EntityUye : IEntity
{
    public int Id { get; set; }
    public string SubeId { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}