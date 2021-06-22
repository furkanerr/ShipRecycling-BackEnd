using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class IHMRapolariManager : IIHMRapolariService
{

    private IIHMRporlariDal _ıhmRporlariDal;

    public IHMRapolariManager(IIHMRporlariDal ıhmRporlariDal)
    {
        _ıhmRporlariDal = ıhmRporlariDal;
    }

    public IDataResult<IHMRapolari> GetById(int iHMRapolariId)
    {
        return new SuccessDataResult<IHMRapolari>(_ıhmRporlariDal.Get(i=>i.Id==iHMRapolariId));
    }

    public IDataResult<List<IHMRapolari>> GetList()
    {
        return new SuccessDataResult<List<IHMRapolari>>(_ıhmRporlariDal.GetList().ToList());
    }

    public IResult Add(IHMRapolari IHMRapolari)
    {
        _ıhmRporlariDal.Add(IHMRapolari);
        return new SuccessResult();
    }

    public IResult Delete(IHMRapolari IHMRapolari)
    {
        _ıhmRporlariDal.Delete(IHMRapolari);
        return new SuccessResult();
    }

    public IResult Update(IHMRapolari IHMRapolari)
    {
        _ıhmRporlariDal.Update(IHMRapolari);
        return new SuccessResult();
    }
}