using Core.Entities;

namespace Entites.Concrete.Uye;

public class UyeVucutOlcu : IEntity
{
    public int Id { get; set; }
    public int UyeId { get; set; }
    public int TurId { get; set; }
    public int Deger { get; set; }
    public DateTime Tarih { get; set; }
}