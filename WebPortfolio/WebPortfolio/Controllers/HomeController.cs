using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPortfolio.Data;
using WebPortfolio.Data.FileManager;
using WebPortfolio.Data.Repository;
using WebPortfolio.Models;

namespace WebPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository _repo;
        private IFileManager _fileManager;

        public HomeController(ILogger<HomeController> logger, IRepository repo, IFileManager fileManager)
        {
            _logger = logger;
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            List<Post> posts = _repo.GetAllPost();
            return View(posts);
        }
        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);

            return View(post);
        }
        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.')+1);

            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{ mime}");
        }
    }
}
