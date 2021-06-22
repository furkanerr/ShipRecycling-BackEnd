using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfKazanlarDal : EfEntityRepositoryBase<Kazanlar, NorthwindContext>, IKazanlarDal
{
}