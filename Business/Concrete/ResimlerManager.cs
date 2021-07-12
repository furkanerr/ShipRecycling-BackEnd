using System;
using System.Collections.Generic;
using System.Linq;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

public class ResimlerManager : IResimlerService
{

    private IResimlerDal _resimlerDal;

    public ResimlerManager(IResimlerDal resimlerDal)
    {
        _resimlerDal = resimlerDal;
    }

    public IDataResult<Resimler> GetById(int gemiId)
    {
        return new SuccessDataResult<Resimler>(_resimlerDal.Get(r=>r.GemiId==gemiId));
    }

    public IDataResult<List<Resimler>> GetList()
    {
        return new SuccessDataResult<List<Resimler>>(_resimlerDal.GetList().ToList());
    }

    public IResult Add(Resimler resimler, IFormFile file)
    {
        resimler.ResimAdresi = FileHelper.AddAsync(file);
       
        _resimlerDal.Add(resimler);
        return new SuccessResult();
    }

   

    public IResult Delete(Resimler resimler)
    {
        _resimlerDal.Delete(resimler);
        return new SuccessResult();
    }

  

    public IResult Update(Resimler resimler, IFormFile file)
    {
        var oldpath = $@"{Environment.CurrentDirectory}\wwwroot{_resimlerDal.Get(p => p.Id == resimler.Id).ResimAdresi}";
        resimler.ResimAdresi = FileHelper.UpdateAsync(oldpath, file);

        _resimlerDal.Update(resimler);
        return new SuccessResult();
    }
}