using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;

namespace EasyQuisy.Infrastructure.Repositorys;

public class AuthorRepository:Repository<Author>,IAuthorRepository
{
    public AuthorRepository(ApplicationDbContext context) : base(context)
    {
    }
    public override async Task<bool> UpdateAsync(Author entity,long id)
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
    
    public override async Task<Author> GetByIdAsync(long id)
    {
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            return new Author();
        }
    }
}