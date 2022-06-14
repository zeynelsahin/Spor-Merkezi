using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete.SubeIslem;

namespace Entites.Abstract.SubeIslem;

public class EfUyelikSecenekDal : EfEntityRepositoryBase<UyelikSecenek, SporMerkeziContext>, IUyelikSecenekDal
{
}