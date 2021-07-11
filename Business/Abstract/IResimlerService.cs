using System.Collections.Generic;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

public interface IResimlerService
{
    IDataResult<Resimler> GetById(int resimlerId);
    IDataResult<List<Resimler>> GetList();
    IResult Add(Resimler resimler,IFormFile file);
    
    IResult Delete(Resimler resimler);
    IResult Update(Resimler resimler, IFormFile file);

   

}