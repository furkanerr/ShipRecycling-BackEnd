using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

public class EfResimlerDal : EfEntityRepositoryBase<Resimler, NorthwindContext>, IResimlerDal
{
    public bool IsExist(int id)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Resimler.Any(pre => pre.Id == id);
        }
    }
}