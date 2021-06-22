using System.Collections.Generic;
using Core.Utilities.Results;

public interface IGemiTipleriService
{
    IDataResult<GemiTipleri> GetById(int gemiTipleriId);
    IDataResult<List<GemiTipleri>> GetList();
   
    IResult Add(GemiTipleri gemiTipleri);
    IResult Delete(GemiTipleri gemiTipleri);
    IResult Update(GemiTipleri gemiTipleri);

   

}