using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class DengeManager : IDengeService
{

    private IDengeDal _dengeDal;

    public DengeManager(IDengeDal dengeDal)
    {
        _dengeDal = dengeDal;
    }

    public IDataResult<Denge> GetById(int dengeId)
    {
        return new SuccessDataResult<Denge>(_dengeDal.Get(d=>d.Id==dengeId));
    }

    public IDataResult<List<Denge>> GetList()
    {
        return new SuccessDataResult<List<Denge>>(_dengeDal.GetList().ToList());
    }

    public IResult Add(Denge denge)
    {
        _dengeDal.Add(denge);
        return new SuccessResult();
    }

    public IResult Delete(Denge denge)
    {
        _dengeDal.Delete(denge);
        return new SuccessResult();
    }

    public IResult Update(Denge denge)
    {
        _dengeDal.Update(denge);
        return new SuccessResult();
    }
}