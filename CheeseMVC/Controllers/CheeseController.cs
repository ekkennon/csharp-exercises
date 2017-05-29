//day 4 prep
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(Cheese cheese)
        {
            CheeseData.Add(cheese);
            return Redirect("/Cheese");
        }

        public IActionResult Remove()
        {
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RmCheese(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }
            return Redirect("/Cheese");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.editcheese = CheeseData.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, string desc)
        {
            CheeseData.Edit(id, name, desc);
            return Redirect("/Cheese");
        }
    }
}
