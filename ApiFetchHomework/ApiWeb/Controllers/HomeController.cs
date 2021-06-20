using ApiWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelContext _db;

        public HomeController(ModelContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Name,Email,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Role = "user";
                _db.Users.Add(user);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return Content("model state was not valid");

        }

        public IActionResult Login()
        {
            return View();
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
