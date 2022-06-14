using Core.Entities;

namespace Entites.Concrete.Sinif;

public class SinifGunlerVeSaat : IEntity
{
    public int Id { get; set; }
    public int SinifId { get; set; }
    public int GunlerVeSaatId { get; set; }
}