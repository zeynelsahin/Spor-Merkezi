using Core.DataAccess.EntityFramework;
using Entites.Abstract.Kullanici;
using Entites.Concrete.Kullanici;

namespace DataAccess.Concrete.EntityFramework.Kullanici;

public class EfKullaniciGirisDal : EfEntityRepositoryBase<KullaniciGiris, SporMerkeziContext>, IKullaniciGirisDal
{
}