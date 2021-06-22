using System.Collections.Generic;
using System.Linq;
using Business.Constants;
using Core.Utilities.Results;

public class KazanDoldurmaOperasyonlariManager : IKazanDoldurmaOPerasyonlariService
{

    private IKazanDoldurmaOPerasyonlariDal _kazanDoldurmaOPerasyonlariDal;

    public KazanDoldurmaOperasyonlariManager(IKazanDoldurmaOPerasyonlariDal kazanDoldurmaOPerasyonlariDal)
    {
        _kazanDoldurmaOPerasyonlariDal = kazanDoldurmaOPerasyonlariDal;
    }

    public IDataResult<KazanDoldurmaOPerasyonlari> GetById(int kazanDoldurmaOPerasyonlariId)
    {
        return new SuccessDataResult<KazanDoldurmaOPerasyonlari>(_kazanDoldurmaOPerasyonlariDal.Get(k=>k.Id==kazanDoldurmaOPerasyonlariId));
    }

    public IDataResult<List<KazanDoldurmaOPerasyonlari>> GetList()
    {
        return new SuccessDataResult<List<KazanDoldurmaOPerasyonlari>>(_kazanDoldurmaOPerasyonlariDal.GetList().ToList());
    }

    public IResult Add(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari)
    {
        _kazanDoldurmaOPerasyonlariDal.Add(kazanDoldurmaOPerasyonlari);
        return new SuccessResult(Messages.AddError); 
    }

    public IResult Delete(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari)
    {
       
        _kazanDoldurmaOPerasyonlariDal.Delete(kazanDoldurmaOPerasyonlari);
        return new SuccessResult();
    }

    public IResult Update(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari)
    {
        
        _kazanDoldurmaOPerasyonlariDal.Update(kazanDoldurmaOPerasyonlari);
        return new SuccessResult();
    }
}