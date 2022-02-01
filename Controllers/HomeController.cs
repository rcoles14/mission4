using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private Context _context { get; set; }
        public HomeController(Context x)
        {
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
        [HttpGet]
        public IActionResult Movies()
        {
            var movies = _context.responses
                .Include(x => x.CategoryName)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }
        /*Get method*/
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();
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
                ViewBag.Categories = _context.Categories.ToList();
                return View(response);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();

            var movie = _context.responses.Single(x => x.id == id);

            return View("AddMovie", movie);
        }
        [HttpPost]
        public IActionResult Edit(AddResponse response)
        {
            _context.Update(response);
            _context.SaveChanges();
            return RedirectToAction("Movies");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _context.responses.Single(x => x.id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(AddResponse response)
        {
            _context.responses.Remove(response);
            _context.SaveChanges();
            return RedirectToAction("Movies");
        }
    }

}
