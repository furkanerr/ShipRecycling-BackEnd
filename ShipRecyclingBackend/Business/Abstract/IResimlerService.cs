using System.Collections.Generic;
using Core.Utilities.Results;

public interface IResimlerService
{
    IDataResult<Resimler> GetById(int resimlerId);
    IDataResult<List<Resimler>> GetList();
   
    IResult Add(Resimler resimler);
    IResult Delete(Resimler resimler);
    IResult Update(Resimler resimler);

   

}