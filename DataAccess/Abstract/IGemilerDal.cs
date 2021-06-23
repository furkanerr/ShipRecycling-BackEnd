using System.Collections.Generic;
using Core.DataAccess;
using Entities.Dtos;

public interface IGemilerDal:IEntityRepository<Gemiler>
{
    public List<GemiDetailDto> GetGemiDetails();
    public GemiDetailDto GetGemiDetailsById(int Id);
}