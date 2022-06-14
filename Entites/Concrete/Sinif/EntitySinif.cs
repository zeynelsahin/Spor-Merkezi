using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entites.Concrete.Sinif;

[Table("EntitySinif.Siniflar")]
public class EntitySinif : IEntity
{
    public int Id { get; set; }
    public int SubeId { get; set; }
    public int HizmetId { get; set; }
    public string Ad { get; set; }
    public int Kapasite { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}