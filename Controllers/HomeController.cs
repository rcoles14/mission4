using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context _context { get; set; }
        public HomeController(ILogger<HomeController> logger, Context x)
        {
            _logger = logger;
            _context = x;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcast()
        {
            return View();
        }
/*Get method*/
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
/*Post Method*/
        [HttpPost]
        public IActionResult AddMovie(AddResponse response)
        {
/*Check inputs for validity before sending to database*/
            if (ModelState.IsValid)
            {
                _context.Add(response);
                _context.SaveChanges();
                return View("MovieAdded", response);
            }
/*If not valid, show errors*/
            else
            {
                return View();
            }
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
