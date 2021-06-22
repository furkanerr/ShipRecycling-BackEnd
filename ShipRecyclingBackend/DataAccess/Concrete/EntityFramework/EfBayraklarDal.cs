using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfBayraklarDal : EfEntityRepositoryBase<Bayraklar, NorthwindContext>, IBayraklarDal
{
}