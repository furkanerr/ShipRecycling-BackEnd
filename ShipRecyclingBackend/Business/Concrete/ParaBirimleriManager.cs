using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class ParaBirimleriManager : IParaBirimleriService
{

    private IParaBirimleriDal _paraBirimleriDal;

    public ParaBirimleriManager(IParaBirimleriDal paraBirimleriDal)
    {
        _paraBirimleriDal = paraBirimleriDal;
    }

    public IDataResult<ParaBirimleri> GetById(int paraBirimId)
    {
        return new SuccessDataResult<ParaBirimleri>(_paraBirimleriDal.Get(p=>p.Id==paraBirimId));
    }

    public IDataResult<List<ParaBirimleri>> GetList()
    {
        return new SuccessDataResult<List<ParaBirimleri>>(_paraBirimleriDal.GetList().ToList());
    }

    public IResult Add(ParaBirimleri paraBirimi)
    {
        _paraBirimleriDal.Add(paraBirimi);
        return new SuccessResult();
    }

    public IResult Delete(ParaBirimleri paraBirimi)
    {
        _paraBirimleriDal.Delete(paraBirimi);
        return new SuccessResult();
    }

    public IResult Update(ParaBirimleri paraBirimi)
    {
        _paraBirimleriDal.Update(paraBirimi);
        return new SuccessResult();
    }
}