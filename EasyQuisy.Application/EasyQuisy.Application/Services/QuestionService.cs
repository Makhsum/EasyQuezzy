using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.ServiceInterfaces;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public class QuestionService:BaseService<Question>,IQuestionService
{
    private readonly IUnitOfWork _unitOfWork;

    public QuestionService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public override async Task<bool> AddAsync(Question entity)
    {
       bool result =  await _unitOfWork.Questions.AddAsync(entity);
         if (result)
         {
             await _unitOfWork.CompleteAsync();
         }

         return result;
    }

    public override async Task<bool> UpdateAsync(Question entity, long id)
    {
        bool result =  await _unitOfWork.Questions.UpdateAsync(entity, id);
         if (result)
         {
             await _unitOfWork.CompleteAsync();
         }

         return result;
    }

    public override async Task<bool> DeleteAsync(long id)
    {
        bool result= await _unitOfWork.Questions.DeleteAsync(id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override Task<IEnumerable<Question>> GetAllAsync()
    {
        return _unitOfWork.Questions.GetAllAsync();
    }
}