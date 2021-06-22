using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfMalzemelerDal : EfEntityRepositoryBase<Malzemeler, NorthwindContext>, IMalzemelerDal
{
}