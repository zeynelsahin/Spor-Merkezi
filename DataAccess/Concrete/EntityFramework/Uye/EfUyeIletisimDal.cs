using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete.Uye;

namespace Entites.Abstract.Uye;

public class EfUyeIletisimDal : EfEntityRepositoryBase<UyeIletisim, SporMerkeziContext>, IUyeIletisimDal
{
}