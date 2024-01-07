using SonDaoBlog.Core.Repositories;

namespace SonDaoBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }

        Task<int> CompleteAsync();
    }
}
