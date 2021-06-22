using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class KaldırmaOperasyonuPlanlariManager : IKaldırmaOperasyonuPlanlariService
{

    private IKaldırmaOperasyonuPlanlariDal _kaldırmaOperasyonuPlanlariDal;

    public KaldırmaOperasyonuPlanlariManager(IKaldırmaOperasyonuPlanlariDal kaldırmaOperasyonuPlanlariDal)
    {
        _kaldırmaOperasyonuPlanlariDal = kaldırmaOperasyonuPlanlariDal;
    }

    public IDataResult<KaldirmaOperasyonuPlanlari> GetById(int KaldırmaOperasyonuPlanlariId)
    {
        return new SuccessDataResult<KaldirmaOperasyonuPlanlari>(_kaldırmaOperasyonuPlanlariDal.Get(k=>k.Id==KaldırmaOperasyonuPlanlariId));
    }

    public IDataResult<List<KaldirmaOperasyonuPlanlari>> GetList()
    {
        return new SuccessDataResult<List<KaldirmaOperasyonuPlanlari>>(_kaldırmaOperasyonuPlanlariDal.GetList().ToList());
    }

    public IResult Add(KaldirmaOperasyonuPlanlari kaldırmaOperasyonuPlanlari)
    {
        _kaldırmaOperasyonuPlanlariDal.Add(kaldırmaOperasyonuPlanlari);
        return new SuccessResult();
    }

    public IResult Delete(KaldirmaOperasyonuPlanlari kaldırmaOperasyonuPlanlari)
    {
        _kaldırmaOperasyonuPlanlariDal.Delete(kaldırmaOperasyonuPlanlari);
        return new SuccessResult();
    }

    public IResult Update(KaldirmaOperasyonuPlanlari kaldırmaOperasyonuPlanlari)
    {
        _kaldırmaOperasyonuPlanlariDal.Update(kaldırmaOperasyonuPlanlari);
        return new SuccessResult();
    }
}