using System.Collections.Generic;
using Core.Utilities.Results;

public interface IBayrakService
{
    IDataResult<Bayraklar> GetById(int bayrakId);
    IDataResult<List<Bayraklar>> GetList();
   
    IResult Add(Bayraklar bayrak);
    IResult Delete(Bayraklar bayrak);
    IResult Update(Bayraklar bayrak);

    

}