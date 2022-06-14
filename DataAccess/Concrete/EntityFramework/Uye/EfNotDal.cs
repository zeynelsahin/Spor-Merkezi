using Core.DataAccess.EntityFramework;
using Entites.Abstract.Uye;
using Entites.Concrete.Uye;

namespace DataAccess.Concrete.EntityFramework.Uye;

public class EfNotDal : EfEntityRepositoryBase<Not, SporMerkeziContext>, INotDal
{
}