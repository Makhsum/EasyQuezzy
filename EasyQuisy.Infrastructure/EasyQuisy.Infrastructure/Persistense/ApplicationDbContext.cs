using Microsoft.EntityFrameworkCore;

namespace EasyQuisy.Infrastructure.Persistense
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}