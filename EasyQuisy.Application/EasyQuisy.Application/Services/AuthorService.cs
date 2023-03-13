using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.ServiceInterfaces;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public class AuthorService:BaseService<Author>,IAuthorService
{
    private readonly IUnitOfWork _unitOfWork;

    public AuthorService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public override async Task<bool> AddAsync(Author entity)
    {
        bool result =  await _unitOfWork.Authors.AddAsync(entity);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> UpdateAsync(Author entity, long id)
    {
        bool result =  await _unitOfWork.Authors.UpdateAsync(entity, id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> DeleteAsync(long id)
    {
        bool result= await _unitOfWork.Authors.DeleteAsync(id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }
}