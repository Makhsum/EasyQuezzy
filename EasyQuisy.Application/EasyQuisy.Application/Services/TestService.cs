using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Domain.Models;

namespace EasyQuisy.Application.Services;

public class TestService:BaseService<Test>
{
    private readonly IUnitOfWork _unitOfWork;

    public TestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    
}