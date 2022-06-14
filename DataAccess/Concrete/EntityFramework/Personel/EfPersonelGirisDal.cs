using Core.DataAccess.EntityFramework;
using Entites.Abstract.Personel;
using Entites.Concrete.Personel;

namespace DataAccess.Concrete.EntityFramework.Personel;

public class EfPersonelGirisDal : EfEntityRepositoryBase<PersonelGiris, SporMerkeziContext>, IPersonelGirisDal
{
}