using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class BlokMateryalIcerikManager : IBlokMateryalIcerikService
{
   
    private IBlok_MateryalIcerikDal _blokMateryalIcerikDal;

    public BlokMateryalIcerikManager(IBlok_MateryalIcerikDal blokMateryalIcerikDal)
    {
        _blokMateryalIcerikDal = blokMateryalIcerikDal;
    }


    public IDataResult<Blok_MateryalIcerik> GetById(int blokMateryalIcerikId)
    {
        throw new System.NotImplementedException();
    }

    public IDataResult<List<Blok_MateryalIcerik>> GetList()
    {
        return new SuccessDataResult<List<Blok_MateryalIcerik>>(_blokMateryalIcerikDal.GetList().ToList());
    }

    public IResult Add(Blok_MateryalIcerik blokMateryalIcerik)
    {
        _blokMateryalIcerikDal.Add(blokMateryalIcerik);
        return new SuccessResult();
    }

    public IResult Delete(Blok_MateryalIcerik blokMateryalIcerik)
    {
        _blokMateryalIcerikDal.Delete(blokMateryalIcerik);
        return new SuccessResult();
    }

    public IResult Update(Blok_MateryalIcerik blokMateryalIcerik)
    {
        _blokMateryalIcerikDal.Update(blokMateryalIcerik);
        return new SuccessResult();
    }

   
}