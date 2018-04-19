using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remastering.Models;

namespace Remastering.Controllers
{
    public class HomeController : Controller
    {
        private RemasteringContext db;
        public HomeController(RemasteringContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Albums.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Album album)
        {
            db.Albums.Add(album);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
