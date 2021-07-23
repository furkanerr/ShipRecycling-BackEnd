using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Dtos;

public interface IGemilerDal:IEntityRepository<Gemiler>
{
    public List<GemiDetailDto> GetGemiDetails(Expression<Func<Gemiler, bool>> filter = null);
  //  public GemiDetailDto GetGemiDetailsById(int Id);
}