using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;

namespace EasyQuisy.Infrastructure.Repositorys;

public class TestRepository:Repository<Test>,ITestRepository
{
    public TestRepository(ApplicationDbContext context) : base(context)
    {
    }
    public override async Task<bool> UpdateAsync(Test entity,long id)
    {
       
        try
        {
            var updatedentity = await _dbSet.FindAsync(id);
            updatedentity.Name = entity.Name;
            updatedentity.Author = entity.Author;
            updatedentity.Description = entity.Description;
            updatedentity.Questions = entity.Questions;
            updatedentity.AuthorId = entity.AuthorId;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public override async Task<Test> GetByIdAsync(long id)
    {
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            return new Test();
        }
    }
}