using Microsoft.AspNetCore.Mvc;
using SonDaoBlog.Core.Models;

namespace SonDaoBlog.WebApp.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
