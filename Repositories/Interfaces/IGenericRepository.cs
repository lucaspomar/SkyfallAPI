using System.Linq.Expressions;

namespace SkyfallAPI.Repositories.Interfaces;

public interface IGenericRepository<T> where T : class
{
    T? GetById(long id);
    List<T> GetAll();
    void Add(T entity);
    void AddList(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(T entity);
    void DeleteList(IEnumerable<T> entities);
    List<T> Find(Expression<Func<T, bool>> expression);
    int Save();
    bool CheckIfExists(long id);
}
