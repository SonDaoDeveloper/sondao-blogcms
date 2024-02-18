using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SonDaoBlog.Core.Domain.Identity;
using SonDaoBlog.Core.Repositories;
using SonDaoBlog.Core.SeedWorks;
using SonDaoBlog.Data;
using SonDaoBlog.Data.Repositories;

namespace TeduBlog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SonDaoBlogContext _context;

        public UnitOfWork(SonDaoBlogContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            _context = context;
            Posts = new PostRepository(context, mapper, userManager);
            PostCategories = new PostCategoryRepository(context, mapper);
            Series = new SeriesRepository(context, mapper);
            Transactions = new TransactionRepository(context, mapper);
            Users = new UserRepository(context);
        }
        public IPostRepository Posts { get; private set; }

        public IPostCategoryRepository PostCategories { get; private set; }

        public ISeriesRepository Series { get; private set; }
        public ITransactionRepository Transactions { get; private set; }

        public IUserRepository Users { get; private set; }

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
