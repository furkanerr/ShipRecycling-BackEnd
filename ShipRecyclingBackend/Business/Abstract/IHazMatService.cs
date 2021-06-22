using System.Collections.Generic;
using Core.Utilities.Results;

public interface IHazMatService
{
    IDataResult<HazMat> GetById(int hazMatId);
    IDataResult<List<HazMat>> GetList();
    IDataResult<List<HazMat>> GetListByHazMatTipi(int hazMatTipiId);
    IResult Add(HazMat hazMat);
    IResult Delete(HazMat hazMat);
    IResult Update(HazMat hazMat);

    

}