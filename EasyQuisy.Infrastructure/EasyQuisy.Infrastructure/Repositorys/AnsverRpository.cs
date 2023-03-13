
using EasyQuisy.Application.Common.Abstractions.RepositoryInterfaces;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;
using Microsoft.EntityFrameworkCore;

namespace EasyQuisy.Infrastructure.Repositorys;

public class AnsverRpository:Repository<Ansver>,IAnsverRepository
{
    public AnsverRpository(ApplicationDbContext context) : base(context)
    {
    }
    

    public override async Task<bool> UpdateAsync(Ansver entity,long id)
    {
       
        try
        {
            var updatedentity = await _dbSet.FindAsync(id);
            updatedentity.Body = entity.Body;
            updatedentity.Question = entity.Question;
            updatedentity.IsRight = entity.IsRight;
            updatedentity.QuestionId = entity.QuestionId;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public override async Task<Ansver> GetByIdAsync(long id)
    {
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            return new Ansver();
        }
    }

  
}