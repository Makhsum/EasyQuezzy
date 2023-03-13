using EasyQuisy.Application.Common.Abstractions.RepositoryInterfaces;

namespace EasyQuisy.Application.Common.Abstractions;

public interface IUnitOfWork
{
    IAnsverRepository Ansvers { get;}
    IAuthorRepository Authors { get;}
    IQuestionRepository Questions { get;}
    IQuestionSettingsRepository QuestionSettings { get;}
    ITestRepository Tests { get;}
    Task CompleteAsync();
}