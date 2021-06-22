using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfUygunmuDal : EfEntityRepositoryBase<Uygunmu, NorthwindContext>, IUygunmuDal
{
}