using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete.Tanim;

namespace Entites.Abstract.Tanim;

public class EfGunlerVeSaatDal : EfEntityRepositoryBase<GunlerVeSaat, SporMerkeziContext>, IGunlerVeSaatDal
{
}