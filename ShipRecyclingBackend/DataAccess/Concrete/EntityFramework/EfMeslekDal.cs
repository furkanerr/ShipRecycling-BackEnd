using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfMeslekDal : EfEntityRepositoryBase<Meslekler, NorthwindContext>, IMeslekDal
{
}