using EasyQuisy.Application.Common.Abstractions.RepositoryInterfaces;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;

namespace EasyQuisy.Infrastructure.Repositorys;

public class QuestionRepository:Repository<Question>,IQuestionRepository
{
    public QuestionRepository(ApplicationDbContext context) : base(context)
    {
    }
    public override async Task<bool> UpdateAsync(Question entity,long id)
    {
       
        try
        {
            var updatedentity = await _dbSet.FindAsync(id);
            updatedentity.QuestionBody = entity.QuestionBody;
            updatedentity.TypeOfQuestion = entity.TypeOfQuestion;
            updatedentity.VariantsOfAnsvers = entity.VariantsOfAnsvers;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public override async Task<Question> GetByIdAsync(long id)
    {
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            return new Question();
        }
    }
}