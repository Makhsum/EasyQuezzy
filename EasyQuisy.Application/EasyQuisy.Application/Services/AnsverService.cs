using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.ServiceInterfaces;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public class AnsverService:BaseService<Ansver>,IAnsverService
{
    private readonly IUnitOfWork _unitOfWork;

    public AnsverService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public override async Task<bool> AddAsync(Ansver entity)
    {
        bool result =  await _unitOfWork.Ansvers.AddAsync(entity);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> UpdateAsync(Ansver entity, long id)
    {
        bool result =  await _unitOfWork.Ansvers.UpdateAsync(entity, id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override async Task<bool> DeleteAsync(long id)
    {
        bool result= await _unitOfWork.Ansvers.DeleteAsync(id);
        if (result)
        {
            await _unitOfWork.CompleteAsync();
        }

        return result;
    }

    public override Task<IEnumerable<Ansver>> GetAllAsync()
    {
        return _unitOfWork.Ansvers.GetAllAsync();
    }
}