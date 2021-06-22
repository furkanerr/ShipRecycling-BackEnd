using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfDengeDal : EfEntityRepositoryBase<Denge, NorthwindContext>, IDengeDal
{
}