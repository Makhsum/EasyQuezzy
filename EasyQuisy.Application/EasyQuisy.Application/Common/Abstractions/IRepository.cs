using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Common.Abstractions
{
    public interface IRepository<TEntity> where TEntity:EntityBase
    {
        Task<bool> AddAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(long id);
        Task<bool> UpdateAsync(TEntity entity,long id);
        Task<bool> DeleteAsync(long id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}