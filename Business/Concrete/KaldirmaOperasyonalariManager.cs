using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class KaldirmaOperasyonalariManager : IKaldirmaOperasyonalariService
{

    private IKaldirmaOperasyonalariDal _kaldirmaOperasyonalariDal;

    public KaldirmaOperasyonalariManager(IKaldirmaOperasyonalariDal kaldirmaOperasyonalariDal)
    {
        _kaldirmaOperasyonalariDal = kaldirmaOperasyonalariDal;
    }


    public IDataResult<KaldirmaOperasyonalari> GetById(int kaldirmaOperasyonalariId)
    {
        return new SuccessDataResult<KaldirmaOperasyonalari>(_kaldirmaOperasyonalariDal.Get(k=>k.Id==kaldirmaOperasyonalariId));
    }

    public IDataResult<List<KaldirmaOperasyonalari>> GetList()
    {
        return new SuccessDataResult<List<KaldirmaOperasyonalari>>(_kaldirmaOperasyonalariDal.GetList().ToList());
    }

    public IResult Add(KaldirmaOperasyonalari kaldirmaOperasyonalari)
    {
        _kaldirmaOperasyonalariDal.Add(kaldirmaOperasyonalari);
        return new SuccessResult();
    }

    public IResult Delete(KaldirmaOperasyonalari kaldirmaOperasyonalari)
    {
        _kaldirmaOperasyonalariDal.Delete(kaldirmaOperasyonalari);
        return new SuccessResult();
    }

    public IResult Update(KaldirmaOperasyonalari kaldirmaOperasyonalari)
    {
        _kaldirmaOperasyonalariDal.Update(kaldirmaOperasyonalari);
        return new SuccessResult();
    }
}