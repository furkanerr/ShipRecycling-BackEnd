using System.Collections.Generic;
using Core.Utilities.Results;

public interface ICalisanMesleklerService
{
    IDataResult<Calisan_Meslekler> GetById(int calisan_MesleklerId);
    IDataResult<List<Calisan_Meslekler>> GetList();
   
    IResult Add(Calisan_Meslekler calisan_Meslekler);
    IResult Delete(Calisan_Meslekler calisan_Meslekler);
    IResult Update(Calisan_Meslekler calisan_Meslekler);

    IResult TransactionalOperation(Calisan_Meslekler calisan_Meslekler);

}