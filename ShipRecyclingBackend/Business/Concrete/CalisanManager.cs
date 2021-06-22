using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class CalisanManager : ICalisanService
{
   
    private ICalisanDal _calisanDal;

    public CalisanManager(ICalisanDal calisanDal)
    {
        _calisanDal = calisanDal;
    }


    public IDataResult<Calisan> GetById(int calisanId)
    {
        return new SuccessDataResult<Calisan>(_calisanDal.Get(c=>c.ID==calisanId));
    }

    public IDataResult<List<Calisan>> GetList()
    {
        return new SuccessDataResult<List<Calisan>>(_calisanDal.GetList().ToList());
    }

    public IResult Add(Calisan calisan)
    {
        _calisanDal.Add(calisan);
        return new SuccessResult();
    }

    public IResult Delete(Calisan calisan)
    {
        _calisanDal.Delete(calisan);
        return new SuccessResult();
    }

    public IResult Update(Calisan calisan)
    {
        _calisanDal.Update(calisan);
        return new SuccessResult();
    }
}