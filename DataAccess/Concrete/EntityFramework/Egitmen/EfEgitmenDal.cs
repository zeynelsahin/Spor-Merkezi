using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.Egitmen;
using Entites.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfEgitmenDal : EfEntityRepositoryBase<Egitmen, SporMerkeziContext>, IEgitmenDal
{
}