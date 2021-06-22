using System.Collections.Generic;
using Core.Utilities.Results;

public  interface IDengeService
{
    IDataResult<Denge> GetById(int dengeId);
    IDataResult<List<Denge>> GetList();
   
    IResult Add(Denge denge);
    IResult Delete(Denge denge);
    IResult Update(Denge denge);

    

}