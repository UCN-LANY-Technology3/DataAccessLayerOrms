namespace ProductManagerDAL;

public interface IDao<TEntity> where TEntity : class
{
    TEntity Create(TEntity entity);
    
    IEnumerable<TEntity> Read();

    TEntity Update(TEntity entity);

    TEntity Delete(TEntity entity);
}
