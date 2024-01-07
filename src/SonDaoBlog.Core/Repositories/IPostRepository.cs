using SonDaoBlog.Core.Domain.Content;
using SonDaoBlog.Core.Models;
using SonDaoBlog.Core.Models.Content;
using SonDaoBlog.Core.SeedWorks;

namespace SonDaoBlog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
