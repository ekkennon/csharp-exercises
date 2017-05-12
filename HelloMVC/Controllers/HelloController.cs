using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'> <input type='text' name='name' /> <input type='submit' value='Greet me!' /></form>";

            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // need to comment out above method for this to work
        public IActionResult Holder1(string name)
        {
            return Redirect("/Hello/Aloha");
        }

    // alter the route to the controller to be: /Hello/Aloha
    [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
