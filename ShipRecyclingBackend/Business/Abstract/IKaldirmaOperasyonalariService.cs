using System.Collections.Generic;
using Core.Utilities.Results;

public interface IKaldirmaOperasyonalariService
{
    IDataResult<KaldirmaOperasyonalari> GetById(int kaldirmaOperasyonalariId);
    IDataResult<List<KaldirmaOperasyonalari>> GetList();
  
    IResult Add(KaldirmaOperasyonalari kaldirmaOperasyonalari);
    IResult Delete(KaldirmaOperasyonalari kaldirmaOperasyonalari);
    IResult Update(KaldirmaOperasyonalari kaldirmaOperasyonalari);

    

}