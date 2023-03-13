using EasyQuisy.Application.Common.Abstractions.ServiceInterfaces;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public abstract class BaseService<TEntity>:IBaseService<TEntity> where TEntity:EntityBase
{
    public virtual async Task<bool> AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<TEntity> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<bool> UpdateAsync(TEntity entity, long id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}