using SonDaoBlog.Core.Domain.Content;
using SonDaoBlog.Core.Models;
using SonDaoBlog.Core.Models.Content;
using SonDaoBlog.Core.SeedWorks;

namespace SonDaoBlog.Core.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory, Guid>
    {
        Task<PagedResult<PostCategoryDto>> GetAllPaging(string? keyword, int pageIndex = 1, int pageSize = 10);
        Task<bool> HasPost(Guid categoryId);
    }
}
