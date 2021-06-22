using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class BlokManager : IBloklarService
{
   
    private IBloklarDal _bloklarDal;

    public BlokManager(IBloklarDal bloklarDal)
    {
        _bloklarDal = bloklarDal;
    }


    public IDataResult<Bloklar> GetById(int blokId)
    {
        return new SuccessDataResult<Bloklar>(_bloklarDal.Get(b=>b.ID==blokId));
    }

    IDataResult<List<Bloklar>> IBloklarService.GetList()
    {
        return new SuccessDataResult<List<Bloklar>>(_bloklarDal.GetList().ToList());
    }

    public IResult Add(Bloklar blok)
    {
        _bloklarDal.Add(blok);
        return new SuccessResult();
    }

    public IResult Delete(Bloklar blok)
    {
        _bloklarDal.Delete(blok);
        return new SuccessResult();
    }

    public IResult Update(Bloklar blok)
    {
        _bloklarDal.Update(blok);
        return new SuccessResult();
    }

    




   
}