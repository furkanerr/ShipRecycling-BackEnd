using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Dtos;

public interface IGemilerService
{
    IDataResult<Gemiler> GetById(int gemiId);
    IDataResult<List<Gemiler>> GetList();
    IDataResult<List<Gemiler>> GetListByGemiTipi(int gemiTipiId);
    IResult Add(Gemiler gemi);
    IResult Delete(Gemiler gemi);
    IResult Update(Gemiler gemi);
    IDataResult< List<GemiDetailDto>> GetGemiDetails();
    IDataResult< List<GemiDetailDto>> GetGemiDetailsByGemiId(int Id);



}