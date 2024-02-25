using Microsoft.AspNetCore.Mvc;
using SonDaoBlog.Core.SeedWorks;
using SonDaoBlog.WebApp.Models;
using System.Diagnostics;

namespace SonDaoBlog.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel();
            viewModel.LatestPost = await _unitOfWork.Posts.GetLatesPublishedPosts(10);
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
