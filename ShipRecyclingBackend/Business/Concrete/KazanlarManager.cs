using System.Collections.Generic;
using System.Linq;
using Business.Constants;
using Core.Utilities.Results;

public class KazanlarManager : IKazanlarService
{

    private IKazanlarDal _kazanlarDal;

    public KazanlarManager(IKazanlarDal kazanlarDal)
    {
        _kazanlarDal = kazanlarDal;
    }

    public IDataResult<Kazanlar> GetById(int kazanlarId)
    {
        return new SuccessDataResult<Kazanlar>(_kazanlarDal.Get(k=>k.ID==kazanlarId));
    }

    public IDataResult<List<Kazanlar>> GetList()
    {
        return new SuccessDataResult<List<Kazanlar>>(_kazanlarDal.GetList().ToList());
    }

    public IResult Add(Kazanlar kazan)
    {
        _kazanlarDal.Add(kazan);
        return new SuccessResult(Messages.Added);
    }

    public IResult Delete(Kazanlar kazan)
    {
        _kazanlarDal.Delete(kazan);
        return new SuccessResult();
    }

    public IResult Update(Kazanlar kazan)
    {
        _kazanlarDal.Update(kazan);
        return new SuccessResult();
    }
}