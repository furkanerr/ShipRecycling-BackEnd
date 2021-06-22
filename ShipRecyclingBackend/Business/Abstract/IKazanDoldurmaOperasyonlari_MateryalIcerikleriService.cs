using System.Collections.Generic;
using Core.Utilities.Results;

public interface IKazanDoldurmaOperasyonlari_MateryalIcerikleriService
{
    IDataResult<KazanDoldurmaOperasyonlari_MateryalIcerikleri> GetById(int kazanDoldurmaOperasyonlari_MateryalIcerikleriId);
    IDataResult<List<KazanDoldurmaOperasyonlari_MateryalIcerikleri>> GetList();
  
    IResult Add(KazanDoldurmaOperasyonlari_MateryalIcerikleri kazanDoldurmaOperasyonlari_MateryalIcerikleri);
    IResult Delete(KazanDoldurmaOperasyonlari_MateryalIcerikleri kazanDoldurmaOperasyonlari_MateryalIcerikleri);
    IResult Update(KazanDoldurmaOperasyonlari_MateryalIcerikleri kazanDoldurmaOperasyonlari_MateryalIcerikleri);

 

}