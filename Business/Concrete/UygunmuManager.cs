using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class UygunmuManager : IUygunmuService
{

    private IUygunmuDal _uygunmuDal;

    public UygunmuManager(IUygunmuDal uygunmuDal)
    {
        _uygunmuDal = uygunmuDal;
    }

    public IDataResult<Uygunmu> GetById(int UygunmuId)
    {
        return new SuccessDataResult<Uygunmu>(_uygunmuDal.Get(u=>u.Id==UygunmuId));
    }

    public IDataResult<List<Uygunmu>> GetList()
    {
        return new SuccessDataResult<List<Uygunmu>>(_uygunmuDal.GetList().ToList());
    }

    public IResult Add(Uygunmu Uygunmu)
    {
        _uygunmuDal.Add(Uygunmu);
        return new SuccessResult();
    }

    public IResult Delete(Uygunmu Uygunmu)
    {
        _uygunmuDal.Delete(Uygunmu);
        return new SuccessResult();
    }

    public IResult Update(Uygunmu Uygunmu)
    {
        _uygunmuDal.Update(Uygunmu);
        return new SuccessResult();
    }
}