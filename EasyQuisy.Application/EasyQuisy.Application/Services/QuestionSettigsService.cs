using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.ServiceInterfaces;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public class QuestionSettigsService:BaseService<QuestionSettings>, IQuestionSettingsService
{
    private readonly IUnitOfWork _unitOfWork;

    public QuestionSettigsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public override async Task<bool> AddAsync(QuestionSettings entity)
    {
        bool result =  await _unitOfWork.QuestionSettings.AddAsync(entity);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> UpdateAsync(QuestionSettings entity, long id)
    {
        bool result =  await _unitOfWork.QuestionSettings.UpdateAsync(entity, id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> DeleteAsync(long id)
    {
        bool result= await _unitOfWork.QuestionSettings.DeleteAsync(id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override Task<IEnumerable<QuestionSettings>> GetAllAsync()
    {
        return _unitOfWork.QuestionSettings.GetAllAsync();
    }
}