using System.Collections.Generic;
using Core.Utilities.Results;

public interface IBloklarService
{
    IDataResult<Bloklar> GetById(int blokId);
    IDataResult<List<Bloklar>> GetList();
  
    IResult Add(Bloklar blok);
    IResult Delete(Bloklar blok);
    IResult Update(Bloklar blok);



}