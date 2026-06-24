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
    public class ProdutsController : Controller
    {

        public IActionResult Index()
        {
            ViewData["PageTitle"] = "List of Products";
            ViewBag.ProductID = "Pro-0001";
            ViewBag.ProductName = "Laptop";
            ViewBag.ProductPrice = 1000;
            ViewBag.ProductDescription = "This is a high-end laptop with powerful performance and sleek design.";
            return View();
        }
        
    }
}