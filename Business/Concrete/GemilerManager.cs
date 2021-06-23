using System.Collections.Generic;
using System.Linq;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Dtos;

public class GemilerManager : IGemilerService
{

    private IGemilerDal _gemilerDal;

    public GemilerManager(IGemilerDal gemilerDal)
    {
        _gemilerDal = gemilerDal;
    }

    public IDataResult<Gemiler> GetById(int gemiId)
    {
        return new SuccessDataResult<Gemiler>(_gemilerDal.Get(g=>g.Id==gemiId),Messages.GemiListed);
    }

    public IDataResult<List<Gemiler>> GetList()
    {
        return new SuccessDataResult<List<Gemiler>>(_gemilerDal.GetList().ToList(), Messages.GemiListed);
    }

    public IDataResult<List<Gemiler>> GetListByGemiTipi(int gemiTipiId)
    {
        return new SuccessDataResult<List<Gemiler>>(_gemilerDal.GetList(g=>g.GemiTipiID==gemiTipiId).ToList());

    }

    public IResult Add(Gemiler gemi)
    {
      //  IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName), CheckIfCategoryIsEnabled());
        _gemilerDal.Add(gemi);
        return new SuccessResult(Messages.GemiAdded);
    }

    public IResult Delete(Gemiler gemi)
    {
        _gemilerDal.Delete(gemi);
        return new SuccessResult();
    }

    public IResult Update(Gemiler gemi)
    {
        _gemilerDal.Update(gemi);
        return new SuccessResult();
    }

    public IDataResult<List<GemiDetailDto>> GetGemiDetails()
    {
        return new SuccessDataResult<List<GemiDetailDto>>(_gemilerDal.GetGemiDetails().ToList(),Messages.GemiListed);
    }
}