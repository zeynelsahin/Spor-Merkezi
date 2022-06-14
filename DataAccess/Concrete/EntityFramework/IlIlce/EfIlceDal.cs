using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;

namespace Entites.Abstract.IlIlce;

public class EfIlceDal : EfEntityRepositoryBase<Ilce, SporMerkeziContext>, IIlceDal
{
}