using Core.DataAccess.EntityFramework;
using Entites.Abstract.Kullanici;
using Entites.Concrete.Kullanici;

namespace DataAccess.Concrete.EntityFramework.Kullanici;

public class EfKullaniciDal : EfEntityRepositoryBase<EntityKullanici, SporMerkeziContext>, IKullaniciDal
{
}