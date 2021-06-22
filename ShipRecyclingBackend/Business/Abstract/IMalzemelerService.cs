using System.Collections.Generic;
using Core.Utilities.Results;

public interface IMalzemelerService
{
    IDataResult<Malzemeler> GetById(int malzemelerId);
    IDataResult<List<Malzemeler>> GetList();
  
    IResult Add(Malzemeler  malzemeler);
    IResult Delete(Malzemeler  malzemeler);
    IResult Update(Malzemeler  malzemeler);

    

}