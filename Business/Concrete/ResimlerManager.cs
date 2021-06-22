using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class ResimlerManager : IResimlerService
{

    private IResimlerDal _resimlerDal;

    public ResimlerManager(IResimlerDal resimlerDal)
    {
        _resimlerDal = resimlerDal;
    }

    public IDataResult<Resimler> GetById(int resimlerId)
    {
        return new SuccessDataResult<Resimler>(_resimlerDal.Get(r=>r.Id==resimlerId));
    }

    public IDataResult<List<Resimler>> GetList()
    {
        return new ErrorDataResult<List<Resimler>>(_resimlerDal.GetList().ToList());
    }

    public IResult Add(Resimler resimler)
    {
        _resimlerDal.Add(resimler);
        return new SuccessResult();
    }

    public IResult Delete(Resimler resimler)
    {
        _resimlerDal.Delete(resimler);
        return new SuccessResult();
    }

    public IResult Update(Resimler resimler)
    {
        _resimlerDal.Update(resimler);
        return new SuccessResult();
    }
}