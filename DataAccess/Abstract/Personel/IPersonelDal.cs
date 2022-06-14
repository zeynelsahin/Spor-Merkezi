using Core.DataAccess;
using Entites.Concrete.Personel;

namespace Entites.Abstract.Personel;

public interface IPersonelDal : IEntityRepository<EntityPersonel>
{
}