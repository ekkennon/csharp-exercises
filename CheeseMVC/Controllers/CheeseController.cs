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
        private static List<Cheese> Cheeses = new List<Cheese>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Index2()
        {
            foreach (Cheese c in Cheeses)
            {

            }
            return View("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string desc)
        {
            Cheese c = new Cheese();
            c.Name = name;
            c.Desc = desc;
            Cheeses.Add(c);
            return Redirect("/Cheese");
        }
    }
}
