using System.Collections.Generic;
using Core.Utilities.Results;

public interface IBlokMateryalIcerikService
{
    IDataResult<Blok_MateryalIcerik> GetById(int blokMateryalIcerikId);
    IDataResult<List<Blok_MateryalIcerik>> GetList();
   
    IResult Add(Blok_MateryalIcerik blokMateryalIcerik);
    IResult Delete(Blok_MateryalIcerik blokMateryalIcerik);
    IResult Update(Blok_MateryalIcerik blokMateryalIcerik);



}