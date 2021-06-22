using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Business;
using Core.Utilities.Results;

public class BayrakManager : IBayrakService
{
   
    private IBayraklarDal _bayraklarDal;

    public BayrakManager(IBayraklarDal bayraklarDal)
    {
        _bayraklarDal = bayraklarDal;
    }

    

    IDataResult<List<Bayraklar>> IBayrakService.GetList()
    {
        return new SuccessDataResult<List<Bayraklar>>(_bayraklarDal.GetList().ToList(), Messages.BayrakListed);
    }

    public IResult Add(Bayraklar bayrak)
    {
         
            _bayraklarDal.Add(bayrak);

            return  new SuccessResult(Messages.Added);
    }

    public IResult Delete(Bayraklar bayrak)
    {

        _bayraklarDal.Delete(bayrak);
        return new SuccessResult();
    }

    public IResult Update(Bayraklar bayrak)
    {
        _bayraklarDal.Update(bayrak);
        return new SuccessResult();
    }

   

    IDataResult<Bayraklar> IBayrakService.GetById(int bayrakId)
    {
        return new SuccessDataResult<Bayraklar>(_bayraklarDal.Get(b => b.Id == bayrakId));
    }

    
    public IDataResult<List<Bayraklar>> GetList()
    {
        
        return new SuccessDataResult<List<Bayraklar>>(_bayraklarDal.GetList().ToList());
    }

}