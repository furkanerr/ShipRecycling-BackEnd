using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfHazMatTipiDal : EfEntityRepositoryBase<HazMatTipi, NorthwindContext>, IHazMatTipiDal
{
}