using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class HazMatManager : IHazMatService
{

    private IHazMatDal _hazMatDal;

    public HazMatManager(IHazMatDal hazMatDal)
    {
        _hazMatDal = hazMatDal;
    }


    public IDataResult<HazMat> GetById(int hazMatId)
    {
        
        return new SuccessDataResult<HazMat>(_hazMatDal.Get(h=>h.Id==hazMatId));
    }

    public IDataResult<List<HazMat>> GetList()
    {
        return new SuccessDataResult<List<HazMat>>(_hazMatDal.GetList().ToList());
    }

    public IDataResult<List<HazMat>> GetListByHazMatTipi(int hazMatTipiId)
    {
        return new SuccessDataResult<List<HazMat>>(_hazMatDal.GetList(h=>h.HazMatTipID==hazMatTipiId).ToList());
    }

    public IResult Add(HazMat hazMat)
    {
        _hazMatDal.Add(hazMat);
        return new SuccessResult();
    }

    public IResult Delete(HazMat hazMat)
    {
        _hazMatDal.Delete(hazMat);
        return new SuccessResult();
    }

    public IResult Update(HazMat hazMat)
    {
        _hazMatDal.Update(hazMat);
        return new SuccessResult();
    }
}