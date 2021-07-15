using Core.DataAccess;

public interface IResimlerDal:IEntityRepository<Resimler>
{
    bool IsExist(int id);
}