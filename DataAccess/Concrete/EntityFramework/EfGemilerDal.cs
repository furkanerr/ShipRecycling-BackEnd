using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

public class EfGemilerDal : EfEntityRepositoryBase<Gemiler, NorthwindContext>, IGemilerDal
{
    public List<GemiDetailDto> GetGemiDetails(Expression<Func<Gemiler, bool>> filter = null)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var result = from gemi in filter is null ? context.Gemiler : context.Gemiler.Where(filter)
                        //from g in context.Gemiler
                        // join c in context.GemiTipleri
                        //     on g.GemiTipiID equals c.Id join b in context.Bayraklar 
                        //    on g.BayrakID equals b.Id
                        join gemiTip in context.GemiTipleri
                            on gemi.GemiTipiID equals gemiTip.Id
                            join bayraklar in context.Bayraklar
                                on gemi.BayrakID equals bayraklar.Id
                         select new GemiDetailDto
                         {
                             Id = gemi.Id,
                             GemiTipiName = gemiTip.GemiTipi,
                             GemiSahibiSirket = gemi.GemiSahibiSirket,
                             Tonnage = gemi.Tonnage,
                             IMONo = gemi.IMONo,
                             BayrakName = bayraklar.UlkeAdi
                             
                         };
            return result.ToList();
        }

    }

    
}