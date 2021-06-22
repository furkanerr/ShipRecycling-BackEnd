using System.Collections.Generic;
using Core.Utilities.Results;

public interface IHazMatTipiService
{
    IDataResult<HazMatTipi> GetById(int hazMatTipiId);
    IDataResult<List<HazMatTipi>> GetList();
   
    IResult Add(HazMatTipi hazMatTipi);
    IResult Delete(HazMatTipi hazMatTipi);
    IResult Update(HazMatTipi hazMatTipi);

   

}