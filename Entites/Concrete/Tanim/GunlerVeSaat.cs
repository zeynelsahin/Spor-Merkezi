using Core.Entities;

namespace Entites.Concrete.Tanim;

public class GunlerVeSaat : IEntity
{
    public int Id { get; set; }
    public bool Pts { get; set; }
    public bool Salı { get; set; }
    public bool Car { get; set; }
    public bool Per { get; set; }
    public bool Cum { get; set; }
    public bool Cts { get; set; }
    public bool Paz { get; set; }
    public DateTime BaslangicSaati { get; set; }
    public int Sure { get; set; }
}