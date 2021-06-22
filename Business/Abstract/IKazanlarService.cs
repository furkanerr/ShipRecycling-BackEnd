using System.Collections.Generic;
using Core.Utilities.Results;

public interface IKazanlarService
{
    IDataResult<Kazanlar> GetById(int kazanlarId);
    IDataResult<List<Kazanlar>> GetList();
   
    IResult Add(Kazanlar kazan);
    IResult Delete(Kazanlar kazan);
    IResult Update(Kazanlar kazan);

}