using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfResimlerDal : EfEntityRepositoryBase<Resimler, NorthwindContext>, IResimlerDal
{
}