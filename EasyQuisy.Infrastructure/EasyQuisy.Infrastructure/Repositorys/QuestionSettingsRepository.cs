using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.RepositoryInterfaces;
using EasyQuisy.Domain.Models;
using EasyQuisy.Infrastructure.Persistense;

namespace EasyQuisy.Infrastructure.Repositorys;

public class QuestionSettingsRepository:Repository<QuestionSettings>,IQuestionSettingsRepository
{
    public QuestionSettingsRepository(ApplicationDbContext context) : base(context)
    {
    }
    public override async Task<bool> UpdateAsync(QuestionSettings entity,long id)
    {
       
        try
        {
            var updatedentity = await _dbSet.FindAsync(id);
            updatedentity.Name = entity.Name;
            updatedentity.Time = entity.Time;
            updatedentity.AskQuestion = entity.AskQuestion;
            updatedentity.OfferAnswer = entity.OfferAnswer;
            updatedentity.QuantityOfQuestion = entity.QuantityOfQuestion;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    public override async Task<QuestionSettings> GetByIdAsync(long id)
    {
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            return new QuestionSettings();
        }
    }
}