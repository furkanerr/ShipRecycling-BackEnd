using System.Collections.Generic;
using Core.Utilities.Results;

public interface IOlcuBirimiService
{
    IDataResult<OlcuBirimi> GetById(int OlcuBirimiId);
    IDataResult<List<OlcuBirimi>> GetList();
 
    IResult Add(OlcuBirimi OlcuBirimi);
    IResult Delete(OlcuBirimi OlcuBirimi);
    IResult Update(OlcuBirimi OlcuBirimi);

   

}