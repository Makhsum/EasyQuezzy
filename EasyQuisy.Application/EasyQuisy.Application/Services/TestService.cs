using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.ServiceInterfaces;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public class TestService:BaseService<Test>,ITestService
{
    private readonly IUnitOfWork _unitOfWork;

    public TestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public override async Task<bool> AddAsync(Test entity)
    {
        bool result = await _unitOfWork.Tests.AddAsync(entity);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> UpdateAsync(Test entity, long id)
    {
         bool result =  await _unitOfWork.Tests.UpdateAsync(entity, id);
         if (result)
         {
             await _unitOfWork.CompleteAsync();
         }

         return result;
    }

    public override async Task<bool> DeleteAsync(long id)
    {
        bool result= await _unitOfWork.Tests.DeleteAsync(id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }
}