using Core.DataAccess.EntityFramework;
using Entites.Abstract.Sube;
using Entites.Concrete.Sube;

namespace DataAccess.Concrete.EntityFramework.Sube;

public class EfSubeDal : EfEntityRepositoryBase<EntitySube, SporMerkeziContext>, ISubeDal
{
}