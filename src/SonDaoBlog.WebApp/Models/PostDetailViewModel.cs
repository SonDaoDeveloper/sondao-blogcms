using SonDaoBlog.Core.Models.Content;

namespace SonDaoBlog.WebApp.Models
{
    public class PostDetailViewModel
    {
        public PostDto Post { get; set; }
        public PostCategoryDto Category { get; set; }
    }
}
