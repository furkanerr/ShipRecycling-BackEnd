using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfCalisanDal : EfEntityRepositoryBase<Calisan, NorthwindContext>, ICalisanDal
{
}