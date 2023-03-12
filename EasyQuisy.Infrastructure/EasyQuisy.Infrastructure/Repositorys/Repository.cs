using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;
using Microsoft.EntityFrameworkCore;

namespace EasyQuisy.Infrastructure.Repositorys;

public abstract class Repository<TEntity>:IRepository<TEntity> where TEntity:EntityBase
{
    private readonly ApplicationDbContext _context;
    protected DbSet<TEntity> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    public virtual async Task<bool> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return true;
    }

    public virtual async Task<TEntity> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
       
    }

    public virtual async Task<bool> UpdateAsync(TEntity entity,long id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<bool> DeleteAsync(long id)
    {
        try
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {

            return await _dbSet.ToListAsync();
            
        }
        catch (Exception e)
        {
            return new List<TEntity>();
        }
    }
}