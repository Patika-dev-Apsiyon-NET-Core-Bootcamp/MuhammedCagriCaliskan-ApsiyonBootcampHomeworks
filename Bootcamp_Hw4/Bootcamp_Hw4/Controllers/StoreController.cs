using Bootcamp_Hw4.Data;
using Bootcamp_Hw4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Hw4.Controllers
{
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StoreController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var s = applicationDbContext.Stores.ToList();
            return View(s);
        }

        public IActionResult Menu(int id)
        {
            var m = applicationDbContext.Categories.ToList();
            return View(m);
        }
    }
}
