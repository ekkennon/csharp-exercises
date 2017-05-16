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
            string html = "<form method='post'><input type='text' name='name' /><select name='lang'><option value='english'>English</option><option value='french'>French</option><option value='spanish'>Spanish</option><option value='russian'>Russian</option><option value='british'>British</option></select><input type='submit' value='Greet me!' /></form>";

            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string lang = "english")
        {
            string greeting = "";

            if (lang.Equals("english"))
            {
                greeting = "Hello, ";
            } else if (lang.Equals("russian"))
            {
                greeting = "Privyet, ";
            } else if (lang.Equals("spanish"))
            {
                greeting = "Hola, ";
            } else if (lang.Equals("french"))
            {
                greeting = "Bonjour, ";
            } else if (lang.Equals("british"))
            {
                greeting = "Allo, ";
            }

            return Content(string.Format("<h1>{0}, {1}</h1>", greeting, name), "text/html");
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
