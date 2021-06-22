using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Results;

public class MateryalIcerikleriManager : IMateryalIcerikleriService
{

    private IMateryalIcerikleriDal _materyalIcerikleriDal;

    public MateryalIcerikleriManager(IMateryalIcerikleriDal materyalIcerikleriDal)
    {
        _materyalIcerikleriDal = materyalIcerikleriDal;
    }

    public IDataResult<MateryalIcerikleri> GetById(int MateryalIcerikleriId)
    {
        return new SuccessDataResult<MateryalIcerikleri>(_materyalIcerikleriDal.Get(m=>m.Id==MateryalIcerikleriId));
    }

    public IDataResult<List<MateryalIcerikleri>> GetList()
    {
        return new SuccessDataResult<List<MateryalIcerikleri>>(_materyalIcerikleriDal.GetList().ToList());
    }

    public IResult Add(MateryalIcerikleri materyalIcerikleri)
    {
        _materyalIcerikleriDal.Add(materyalIcerikleri);
        return new SuccessResult();
    }

    public IResult Delete(MateryalIcerikleri materyalIcerikleri)
    {
        _materyalIcerikleriDal.Delete(materyalIcerikleri);
        return new SuccessResult();
    }

    public IResult Update(MateryalIcerikleri materyalIcerikleri)
    {
        _materyalIcerikleriDal.Update(materyalIcerikleri);
        return new SuccessResult();
    }
}