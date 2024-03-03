using SonDaoBlog.Core.Domain.Content;
using SonDaoBlog.Core.Models.Content;
using SonDaoBlog.Core.SeedWorks;

namespace SonDaoBlog.Core.Repositories
{
    public interface ITagRepository : IRepository<Tag, Guid>
    {
        Task<TagDto> GetBySlug(string slug);
    }
}
