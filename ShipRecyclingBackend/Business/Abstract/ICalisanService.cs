using System.Collections.Generic;
using Core.Utilities.Results;

public interface ICalisanService
{
    IDataResult<Calisan> GetById(int calisanId);
    IDataResult<List<Calisan>> GetList();
    
    IResult Add(Calisan calisan);
    IResult Delete(Calisan calisan);
    IResult Update(Calisan calisan);



}