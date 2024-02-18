using SonDaoBlog.Core.Repositories;

namespace SonDaoBlog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; }
        ISeriesRepository Series { get; }
        IPostCategoryRepository PostCategories { get; }
        ITransactionRepository Transactions { get; }
        IUserRepository Users { get; }
        Task<int> CompleteAsync();
    }
}
