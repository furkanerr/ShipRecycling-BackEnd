using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class KazanDoldurmaOperasyonlari_MateryalIcerikleriManager : IKazanDoldurmaOperasyonlari_MateryalIcerikleriService
{

    private IKazanDoldurmaOperasyonlari_MateryalIcerikleriDal _doldurmaOperasyonlariMateryalIcerikleriDal;

    public KazanDoldurmaOperasyonlari_MateryalIcerikleriManager(IKazanDoldurmaOperasyonlari_MateryalIcerikleriDal kazanDoldurmaOperasyonlariMateryalIcerikleriDal)
    {
        _doldurmaOperasyonlariMateryalIcerikleriDal = kazanDoldurmaOperasyonlariMateryalIcerikleriDal;
    }

    public IDataResult<KazanDoldurmaOperasyonlari_MateryalIcerikleri> GetById(int kazanDoldurmaOperasyonlari_MateryalIcerikleriId)
    {
        throw new System.NotImplementedException();
    }

    public IDataResult<List<KazanDoldurmaOperasyonlari_MateryalIcerikleri>> GetList()
    {
        return new SuccessDataResult<List<KazanDoldurmaOperasyonlari_MateryalIcerikleri>>(_doldurmaOperasyonlariMateryalIcerikleriDal.GetList().ToList());
    }

    public IResult Add(KazanDoldurmaOperasyonlari_MateryalIcerikleri kazanDoldurmaOperasyonlari_MateryalIcerikleri)
    {
        _doldurmaOperasyonlariMateryalIcerikleriDal.Add(kazanDoldurmaOperasyonlari_MateryalIcerikleri);
        return new SuccessResult();
    }

    public IResult Delete(KazanDoldurmaOperasyonlari_MateryalIcerikleri kazanDoldurmaOperasyonlari_MateryalIcerikleri)
    {
        _doldurmaOperasyonlariMateryalIcerikleriDal.Delete(kazanDoldurmaOperasyonlari_MateryalIcerikleri);
        return new SuccessResult();
    }

    public IResult Update(KazanDoldurmaOperasyonlari_MateryalIcerikleri kazanDoldurmaOperasyonlari_MateryalIcerikleri)
    {
        _doldurmaOperasyonlariMateryalIcerikleriDal.Update(kazanDoldurmaOperasyonlari_MateryalIcerikleri);
        return new SuccessResult();
    }
}