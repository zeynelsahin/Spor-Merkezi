using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete.Tanim;

namespace Entites.Abstract.Tanim;

public class EfVucutOlcuDal : EfEntityRepositoryBase<VucutOlcu, SporMerkeziContext>, IVucutOlcuDal
{
}