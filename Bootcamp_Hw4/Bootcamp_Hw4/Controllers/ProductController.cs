using Bootcamp_Hw4.Data;
using Bootcamp_Hw4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Hw4.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ProductController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            var p = applicationDbContext.Products.ToList();
            ViewBag.cat = applicationDbContext.Categories.ToList();
            return View(p);
        }

        [HttpPost]
        public IActionResult Product(Product p)
        {
            if(p != null)
            {
                if (ModelState.IsValid)
                {
                    applicationDbContext.Add(p);
                    applicationDbContext.SaveChanges();
                }
            }
            return View("Index");
        }

    }
}
