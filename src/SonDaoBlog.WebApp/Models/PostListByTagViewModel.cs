using SonDaoBlog.Core.Models.Content;
using SonDaoBlog.Core.Models;

namespace SonDaoBlog.WebApp.Models
{
    public class PostListByTagViewModel
    {
        public TagDto Tag { get; set; }
        public PagedResult<PostInListDto> Posts { get; set; }
    }
}
