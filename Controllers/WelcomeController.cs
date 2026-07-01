using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OopMvcApplication.Controllers
{
    [Route("[controller]")]
    public class WelcomeController : Controller
    {        

        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET Core MVC!";
            return View();
        }
        
    }
}