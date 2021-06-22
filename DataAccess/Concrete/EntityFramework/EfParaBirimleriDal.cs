using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfParaBirimleriDal : EfEntityRepositoryBase<ParaBirimleri, NorthwindContext>, IParaBirimleriDal
{
}