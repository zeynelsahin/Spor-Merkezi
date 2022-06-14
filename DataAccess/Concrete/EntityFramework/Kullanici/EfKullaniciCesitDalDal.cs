using Core.DataAccess.EntityFramework;
using Entites.Abstract.Kullanici;
using Entites.Concrete.Kullanici;

namespace DataAccess.Concrete.EntityFramework;

public class EfKullaniciCesitDal : EfEntityRepositoryBase<KullaniciCesit, SporMerkeziContext>, IKullaniciCesitDal
{
}