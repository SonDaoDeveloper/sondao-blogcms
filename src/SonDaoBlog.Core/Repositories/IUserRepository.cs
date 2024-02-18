using SonDaoBlog.Core.Domain.Identity;
using SonDaoBlog.Core.SeedWorks;

namespace SonDaoBlog.Core.Repositories
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task RemoveUserFromRoles(Guid userId, string[] roles);
    }
}
