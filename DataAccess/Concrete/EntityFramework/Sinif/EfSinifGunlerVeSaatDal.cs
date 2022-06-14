using Core.DataAccess.EntityFramework;
using Entites.Abstract.Sinif;
using Entites.Concrete.Sinif;

namespace DataAccess.Concrete.EntityFramework.Sinif;

public class EfSinifGunlerVeSaatDal : EfEntityRepositoryBase<SinifGunlerVeSaat, SporMerkeziContext>, ISinifGublerVeSaatDal
{
}