using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfKaldirmaOperasyonlariDal : EfEntityRepositoryBase<KaldirmaOperasyonalari, NorthwindContext>, IKaldirmaOperasyonalariDal
{
}