using Core.DataAccess.EntityFramework;
using Entites.Abstract.Uye;
using Entites.Concrete.Uye;

namespace DataAccess.Concrete.EntityFramework.Uye;

public class EfUyeDal : EfEntityRepositoryBase<EntityUye, SporMerkeziContext>, IUyeDal
{
}