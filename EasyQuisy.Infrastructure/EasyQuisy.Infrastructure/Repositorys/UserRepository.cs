using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;

namespace EasyQuisy.Infrastructure.Repositorys;

public class UserRepository:Repository<User>,IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }
    public override async Task<bool> UpdateAsync(User entity,long id)
    {
       
        try
        {
            var updatedentity = await _dbSet.FindAsync(id);
            updatedentity.Name = entity.Name;
            updatedentity.LastName = entity.LastName;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public override async Task<User> GetByIdAsync(long id)
    {
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            return new User();
        }
    }
}