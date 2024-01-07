using AutoMapper;
using SonDaoBlog.Core.Repositories;
using SonDaoBlog.Core.SeedWorks;
using SonDaoBlog.Data;
using SonDaoBlog.Data.Repositories;

namespace TeduBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SonDaoBlogContext _context;

        public UnitOfWork(SonDaoBlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }
        public IPostRepository Posts { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
