using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class OlcuBirimiManager : IOlcuBirimiService
{

    private IOlcuBirimiDal _olcuBirimiDal;

    public OlcuBirimiManager(IOlcuBirimiDal olcuBirimiDal)
    {
        _olcuBirimiDal = olcuBirimiDal;
    }

    public IDataResult<OlcuBirimi> GetById(int olcuBirimiId)
    {
        return new SuccessDataResult<OlcuBirimi>(_olcuBirimiDal.Get(o=>o.Id==olcuBirimiId));
    }

    public IDataResult<List<OlcuBirimi>> GetList()
    {
        return new SuccessDataResult<List<OlcuBirimi>>(_olcuBirimiDal.GetList().ToList());
    }

    public IResult Add(OlcuBirimi olcuBirimi)
    {
        _olcuBirimiDal.Add(olcuBirimi);
        return new SuccessResult();
    }

    public IResult Delete(OlcuBirimi olcuBirimi)
    {
        _olcuBirimiDal.Add(olcuBirimi);
        return new SuccessResult();
    }

    public IResult Update(OlcuBirimi olcuBirimi)
    {
        _olcuBirimiDal.Add(olcuBirimi);
        return new SuccessResult();
    }
}