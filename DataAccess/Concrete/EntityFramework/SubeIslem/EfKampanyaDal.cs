using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete.SubeIslem;

namespace Entites.Abstract.SubeIslem;

public class EfKampanyaDal : EfEntityRepositoryBase<Kampanya, SporMerkeziContext>, IKampanyaDal
{
}