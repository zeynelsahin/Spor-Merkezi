using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;

namespace Entites.Abstract.IlIlce;

public class EfIlDal : EfEntityRepositoryBase<Il, SporMerkeziContext>, IIlDal
{
}