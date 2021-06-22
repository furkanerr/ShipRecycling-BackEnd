using System.Collections.Generic;
using System.Linq;
using Business.Constants;
using Core.Utilities.Results;

public class GemiTipleriManager : IGemiTipleriService
{

    private IGemiTipleriDal _gemiTipleriDal;

    public GemiTipleriManager(IGemiTipleriDal gemiTipleriDal)
    {
        _gemiTipleriDal = gemiTipleriDal;
    }
    public IDataResult<GemiTipleri> GetById(int gemiTipleriId)
    {
        return new SuccessDataResult<GemiTipleri>(_gemiTipleriDal.Get(g=>g.Id==gemiTipleriId));
    }

    public IDataResult<List<GemiTipleri>> GetList()
    {
        return new SuccessDataResult<List<GemiTipleri>>(_gemiTipleriDal.GetList().ToList());
    }

    public IResult Add(GemiTipleri gemiTipleri)
    {
        _gemiTipleriDal.Add(gemiTipleri);
        return new SuccessResult(Messages.Added);
    }

    public IResult Delete(GemiTipleri gemiTipleri)
    { 
        _gemiTipleriDal.Delete(gemiTipleri);
        return new SuccessResult();
    }

    public IResult Update(GemiTipleri gemiTipleri)
    {
        _gemiTipleriDal.Update(gemiTipleri);
        return new SuccessResult();
    }
}