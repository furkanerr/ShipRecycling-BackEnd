using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfHazMatDal : EfEntityRepositoryBase<HazMat, NorthwindContext>, IHazMatDal
{
}