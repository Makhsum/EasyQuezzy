using EasyQuisy.Application.Common.Abstractions;
using EasyQuisy.Application.Common.Abstractions.RepositoryInterfaces;
using EasyQuisy.Infrastructure.Persistense;
using EasyQuisy.Infrastructure.Repositorys;

namespace EasyQuisy.Infrastructure;

public class UnitOfWork:IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IAnsverRepository Ansvers { get; }
    public IAuthorRepository Authors { get; }
    public IQuestionRepository Questions { get; }
    public IQuestionSettingsRepository QuestionSettings { get; }
    public ITestRepository Tests { get; }
    public IUserRepository Users { get; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Ansvers = new AnsverRpository(_context);
        Authors = new AuthorRepository(_context);
        Questions = new QuestionRepository(_context);
        QuestionSettings = new QuestionSettingsRepository(_context);
        Tests = new TestRepository(_context);
        Users = new UserRepository(_context);
    }
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
}