using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SonDaoBlog.Core.Domain.Content;
using SonDaoBlog.Core.Models.Content;
using SonDaoBlog.Core.Repositories;
using SonDaoBlog.Data.SeedWorks;

namespace SonDaoBlog.Data.Repositories
{
    public class TagRepository : RepositoryBase<Tag, Guid>, ITagRepository
    {
        private readonly IMapper _mapper;
        public TagRepository(SonDaoBlogContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<TagDto?> GetBySlug(string slug)
        {
            var tag = await _context.Tags.FirstOrDefaultAsync(x => x.Slug == slug);
            if (tag == null) return null;
            return _mapper.Map<TagDto?>(tag);
        }
    }
}
