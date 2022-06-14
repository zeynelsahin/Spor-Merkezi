using Core.Entities;

namespace Entites.Concrete.Uye;

public class UyeDetay : IEntity
{
    public int UyeId { get; set; }
    public string SegirIlceId { get; set; }
    public string TcNo { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Type { get; set; }
}