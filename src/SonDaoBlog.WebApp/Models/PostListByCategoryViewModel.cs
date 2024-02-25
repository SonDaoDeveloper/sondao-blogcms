using SonDaoBlog.Core.Models;
using SonDaoBlog.Core.Models.Content;

namespace SonDaoBlog.WebApp.Models
{
    public class PostListByCategoryViewModel
    {
        public PostCategoryDto Category { get; set; }
        public PagedResult<PostInListDto> Posts { get; set; }
    }
}
