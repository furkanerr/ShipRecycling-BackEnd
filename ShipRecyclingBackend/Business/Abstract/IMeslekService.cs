using System.Collections.Generic;
using Core.Utilities.Results;

public interface IMeslekService
{
    IDataResult<Meslekler> GetById(int MeslekId);
    IDataResult<List<Meslekler>> GetList();

    IResult Add(Meslekler Meslek);
    IResult Delete(Meslekler Meslek);
    IResult Update(Meslekler Meslek);

   

}