using Core.DataAccess.EntityFramework;
using Entites.Abstract.Personel;
using Entites.Concrete.Personel;

namespace DataAccess.Concrete.EntityFramework.Personel;

public class EfPersonelDal : EfEntityRepositoryBase<EntityPersonel, SporMerkeziContext>, IPersonelDal
{
}