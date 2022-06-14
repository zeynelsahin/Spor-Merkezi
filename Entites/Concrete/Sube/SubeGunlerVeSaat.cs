using Core.Entities;

namespace Entites.Concrete.Sube;

public class SubeGunlerVeSaat : IEntity
{
    public int Id { get; set; }
    public int SubeId { get; set; }
    public int GunlerVeSaatId { get; set; }
}