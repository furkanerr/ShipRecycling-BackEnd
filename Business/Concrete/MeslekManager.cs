using System.Collections.Generic;
using System.Linq;
using Business.Constants;
using Core.Utilities.Results;

public class MeslekManager : IMeslekService
{

    private IMeslekDal _meslekDal;

    public MeslekManager(IMeslekDal meslekDal)
    {
        _meslekDal = meslekDal;
    }

    public IDataResult<Meslekler> GetById(int MeslekId)
    {
        return new SuccessDataResult<Meslekler>(_meslekDal.Get(m=>m.ID==MeslekId));
    }

    public IDataResult<List<Meslekler>> GetList()
    {
        return new SuccessDataResult<List<Meslekler>>(_meslekDal.GetList().ToList());
    }

    public IResult Add(Meslekler Meslek)
    {
        _meslekDal.Add(Meslek);
        return new SuccessResult(Messages.Added);
    }

    public IResult Delete(Meslekler Meslek)
    {
        _meslekDal.Add(Meslek);
        return new SuccessResult();
    }

    public IResult Update(Meslekler Meslek)
    {
        _meslekDal.Add(Meslek);
        return new SuccessResult();
    }
}