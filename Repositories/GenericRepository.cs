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
        _context.Set<T>().Add(entity);
    }

    public void AddList(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void DeleteList(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public List<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression).ToList();
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetById(long id)
    {
        return _context.Set<T>().Find(id);
    }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}
