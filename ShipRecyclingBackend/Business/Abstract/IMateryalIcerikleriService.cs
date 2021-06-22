using System.Collections.Generic;
using Core.Utilities.Results;

public interface IMateryalIcerikleriService
{
    IDataResult<MateryalIcerikleri> GetById(int MateryalIcerikleriId);
    IDataResult<List<MateryalIcerikleri>> GetList();
   
    IResult Add(MateryalIcerikleri materyalIcerikleri);
    IResult Delete(MateryalIcerikleri materyalIcerikleri);
    IResult Update(MateryalIcerikleri materyalIcerikleri);

   

}