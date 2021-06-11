using Bootcamp_Hw4.Data;
using Bootcamp_Hw4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Hw4.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            var a = applicationDbContext.Categories.ToList();
            return View(a);
        }

        [HttpPost]
        public IActionResult Add(Category c)
        {
            if (c != null)
            {
                applicationDbContext.Add(c);
                applicationDbContext.SaveChanges();
            }
            return View("Index");
        }

        public JsonResult GetCategory(int id)
        {
            Category c = applicationDbContext.Categories.Select(x => new Category { Id = x.Id, Name = x.Name, Description = x.Description }).FirstOrDefault(n => n.Id == id);
            return Json(c);
        }


        [HttpPost]
        public async Task<IActionResult> EditCategory(Category category)
        {
            Category c = applicationDbContext.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (c != null)
            {
                c.Name = category.Name;
                c.Description = category.Description;

                if (ModelState.IsValid)
                {
                    await applicationDbContext.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index", "Category");
        }
    }
}