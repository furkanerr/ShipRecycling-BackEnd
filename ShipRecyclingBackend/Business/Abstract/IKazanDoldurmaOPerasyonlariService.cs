using System.Collections.Generic;
using Core.Utilities.Results;

public interface IKazanDoldurmaOPerasyonlariService
{
    IDataResult<KazanDoldurmaOPerasyonlari> GetById(int kazanDoldurmaOPerasyonlariId);
    IDataResult<List<KazanDoldurmaOPerasyonlari>> GetList();

    IResult Add(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari);
    IResult Delete(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari);
    IResult Update(KazanDoldurmaOPerasyonlari kazanDoldurmaOPerasyonlari);

   

}