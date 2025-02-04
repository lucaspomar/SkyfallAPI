using System.Linq.Expressions;
using SkyfallAPI.Data;
using SkyfallAPI.Repositories.Interfaces;

namespace SkyfallAPI.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{

    protected readonly SkyfallDbContext _context;

    public GenericRepository(SkyfallDbContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddList(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteList(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
