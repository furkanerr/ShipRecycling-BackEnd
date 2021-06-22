using System.Collections.Generic;
using Core.Utilities.Results;

public interface IParaBirimleriService
{
    IDataResult<ParaBirimleri> GetById(int paraBirimId);
    IDataResult<List<ParaBirimleri>> GetList();
  
    IResult Add(ParaBirimleri paraBirimi);
    IResult Delete(ParaBirimleri paraBirimi);
    IResult Update(ParaBirimleri paraBirimi);

   

}