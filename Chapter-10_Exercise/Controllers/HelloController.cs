using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chapter_10_Exercise.Controllers
{
    [Route("helloworld")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english'>English</option><option value='spanish'>Spanish</option><option value='french'>French</option><option value='italian'>Italian</option><option value='danish'>Danish</option></select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        public IActionResult CreateMessage(string language, string name = "World")
        {
            if (language == "english")
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            } else if (language == "spanish")
            {
                return Content("<h1>Bienvenido a mi solicitud, " + name + "!</h1>", "text/html");
            } else if (language == "french")
            {
                return Content("<h1>Bienvenue sur mon application, " + name + "!</h1>", "text/html");
            } else if (language == "italian")
            {
                return Content("<h1>Benvenuto nella mia domanda, " + name + "!</h1>", "text/html");
            } else if (language == "danish")
            {
                return Content("<h1>Velkommen til min ansøgning, " + name + "!</h1>", "text/html");
            } else
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            }
        }
    }
}
