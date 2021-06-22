using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Dtos;

public class EfBloklarDal : EfEntityRepositoryBase<Bloklar, NorthwindContext>, IBloklarDal
{
}