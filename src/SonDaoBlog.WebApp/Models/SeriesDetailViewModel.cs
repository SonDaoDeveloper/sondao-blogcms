using SonDaoBlog.Core.Models.Content;
using SonDaoBlog.Core.Models;

namespace SonDaoBlog.WebApp.Models
{
    public class SeriesDetailViewModel
    {
        public SeriesDto Series { get; set; }
        public PagedResult<PostInListDto> Posts { get; set; }
    }
}
