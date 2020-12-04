using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASP.Controllers
{
    // Controllers shouold end in suffix "COntroller"
    // controller should contain action methods
    public class HelloController : Controller
    {
        // action methods job is to fullfull the user's request, and return 
        // some IActionResult
        public IActionResult Action1()
        {
            Console.WriteLine("Action Method");

            //ContentResult is the most flexible, low level IActionResult
            return new ContentResult
            {
                Content = $"<html>Hewwo</html>",
                ContentType = "text/html",
                StatusCode = StatusCodes.Status200OK
            };

            // instead we'll use view resul
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
