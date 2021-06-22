using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class MalzemelerManager : IMalzemelerService
{

    private IMalzemelerDal _malzemelerDal;

    public MalzemelerManager(IMalzemelerDal malzemelerDal)
    {
        _malzemelerDal = malzemelerDal;
    }

    public IDataResult<Malzemeler> GetById(int malzemelerId)
    {
        return new SuccessDataResult<Malzemeler>(_malzemelerDal.Get(m=>m.Id==malzemelerId));
    }

    public IDataResult<List<Malzemeler>> GetList()
    {
        return new SuccessDataResult<List<Malzemeler>>(_malzemelerDal.GetList().ToList()); 
    }

    public IResult Add(Malzemeler malzemeler)
    {
        _malzemelerDal.Add(malzemeler);
        return new SuccessResult();
    }

    public IResult Delete(Malzemeler malzemeler)
    {
        _malzemelerDal.Delete(malzemeler);
        return new SuccessResult();
    }

    public IResult Update(Malzemeler malzemeler)
    {
        _malzemelerDal.Update(malzemeler);
        return new SuccessResult();
    }
}