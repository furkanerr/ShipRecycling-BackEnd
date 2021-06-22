using System.Collections.Generic;
using Core.Utilities.Results;

public interface IUygunmuService
{
    IDataResult<Uygunmu> GetById(int UygunmuId);
    IDataResult<List<Uygunmu>> GetList();
   
    IResult Add(Uygunmu Uygunmu);
    IResult Delete(Uygunmu Uygunmu);
    IResult Update(Uygunmu Uygunmu);

   

}