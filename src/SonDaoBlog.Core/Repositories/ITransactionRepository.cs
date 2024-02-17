using SonDaoBlog.Core.Domain.Royalty;
using SonDaoBlog.Core.Models;
using SonDaoBlog.Core.Models.Royalty;
using SonDaoBlog.Core.SeedWorks;

namespace SonDaoBlog.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction, Guid>
    {
        Task<PagedResult<TransactionDto>> GetAllPaging(string? userName,
         int fromMonth, int fromYear, int toMonth, int toYear, int pageIndex = 1, int pageSize = 10);
    }
}
