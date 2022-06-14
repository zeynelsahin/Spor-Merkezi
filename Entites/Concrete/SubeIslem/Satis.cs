using Core.Entities;

namespace Entites.Concrete.SubeIslem;

public class Satis : IEntity
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public int UyelikSecenegiSiniflarId { get; set; }
    public int KampanyaId { get; set; }
    public DateTime BaslangicTarihi { get; set; }
    public DateTime BitisTarihi { get; set; }
    public decimal SatisFiyati { get; set; }
    public bool Durum { get; set; }
    public bool SilmeDurumu { get; set; }
}