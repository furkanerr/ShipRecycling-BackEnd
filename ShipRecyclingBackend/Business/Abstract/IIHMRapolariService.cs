using System.Collections.Generic;
using Core.Utilities.Results;

public interface IIHMRapolariService
{
    IDataResult<IHMRapolari> GetById(int iHMRapolariId);
    IDataResult<List<IHMRapolari>> GetList();
   
    IResult Add(IHMRapolari IHMRapolari);
    IResult Delete(IHMRapolari IHMRapolari);
    IResult Update(IHMRapolari IHMRapolari);

   

}