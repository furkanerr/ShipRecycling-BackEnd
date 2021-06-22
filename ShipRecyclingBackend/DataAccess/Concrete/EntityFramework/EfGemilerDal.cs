using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

public class EfGemilerDal : EfEntityRepositoryBase<Gemiler, NorthwindContext>, IGemilerDal
{
    public List<GemiDetailDto> GetGemiDetails()
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var result = 
                        from g in context.Gemiler
                         join c in context.GemiTipleri
                             on g.GemiTipiID equals c.Id join b in context.Bayraklar 
                            on g.BayrakID equals b.Id
                         select new GemiDetailDto
                         {
                             Id = g.Id,
                             GemiTipiName = c.GemiTipi,
                             GemiSahibiSirket = g.GemiSahibiSirket,
                             Tonnage = g.Tonnage,
                             IMONo = g.IMONo,
                             BayrakName = b.UlkeAdi
                             
                         };
            return result.ToList();
        }

    }
}