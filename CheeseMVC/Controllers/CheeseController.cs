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
            //Cheese c = new Cheese();
            //c.Name = name;
            //c.Desc = desc;
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
            //Cheeses.Remove(Cheeses.Find(x => x.Name.Equals(cheeseName)));
            foreach (int cheeseId in cheeseIds)
            {
                //Cheeses.RemoveAll(c => c.CheeseId == cheeseId);
                CheeseData.Remove(cheeseId);
            }
            return Redirect("/Cheese");
        }
    }
}
