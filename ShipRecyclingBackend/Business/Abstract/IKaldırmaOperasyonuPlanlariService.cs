using System.Collections.Generic;
using Core.Utilities.Results;

public interface IKaldırmaOperasyonuPlanlariService
{
    IDataResult<KaldirmaOperasyonuPlanlari> GetById(int KaldırmaOperasyonuPlanlariId);
    IDataResult<List<KaldirmaOperasyonuPlanlari>> GetList();
   
    IResult Add(KaldirmaOperasyonuPlanlari kaldırmaOperasyonuPlanlari);
    IResult Delete(KaldirmaOperasyonuPlanlari kaldırmaOperasyonuPlanlari);
    IResult Update(KaldirmaOperasyonuPlanlari kaldırmaOperasyonuPlanlari);

  

}