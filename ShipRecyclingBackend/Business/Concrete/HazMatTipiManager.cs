using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class HazMatTipiManager : IHazMatTipiService
{

    private IHazMatTipiDal _hazMatTipiDal;

    public HazMatTipiManager(IHazMatTipiDal hazMatTipiDal)
    {
        _hazMatTipiDal = hazMatTipiDal;
    }

    public IDataResult<HazMatTipi> GetById(int hazMatTipiId)
    {
        return new SuccessDataResult<HazMatTipi>(_hazMatTipiDal.Get(h=>h.Id==hazMatTipiId));
    }

    public IDataResult<List<HazMatTipi>> GetList()
    {
        return new SuccessDataResult<List<HazMatTipi>>(_hazMatTipiDal.GetList().ToList());
    }

    public IResult Add(HazMatTipi hazMatTipi)
    {
        _hazMatTipiDal.Add(hazMatTipi);
        return new SuccessResult();
    }

    public IResult Delete(HazMatTipi hazMatTipi)
    {
        _hazMatTipiDal.Delete(hazMatTipi);
        return new SuccessResult();
    }

    public IResult Update(HazMatTipi hazMatTipi)
    {
        _hazMatTipiDal.Update(hazMatTipi);
        return new SuccessResult();
    }
}