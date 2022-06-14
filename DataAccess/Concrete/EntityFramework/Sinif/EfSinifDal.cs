using Core.DataAccess.EntityFramework;
using Entites.Abstract;
using Entites.Concrete.Sinif;

namespace DataAccess.Concrete.EntityFramework.Sinif;

public class EfSinifDal : EfEntityRepositoryBase<EntitySinif, SporMerkeziContext>, ISinifDal
{
}