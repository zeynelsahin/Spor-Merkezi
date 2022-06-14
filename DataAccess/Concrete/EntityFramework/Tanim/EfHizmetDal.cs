using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete.Tanim;

namespace Entites.Abstract.Tanim;

public class EfHizmetDal : EfEntityRepositoryBase<Hizmet, SporMerkeziContext>, IHizmetDal
{
}