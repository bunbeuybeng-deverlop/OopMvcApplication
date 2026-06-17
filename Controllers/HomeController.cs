using Microsoft.AspNetCore.Mvc;

namespace OopMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ShopInfo()
        {
            int shopId = 1;
            string shopName = "Angkor Tech Store";
            string address = "National Road 6, Siem Reap";
            string openHours = "8:00 AM - 8:00 PM";
            string pagetitle = "First Test MVC";

            ViewBag.ShopId = shopId;
            ViewBag.ShopName = shopName;
            ViewBag.Address = address;
            ViewBag.OpenHours = openHours;
            ViewBag.PageTitle = pagetitle;
            return View();
        }
    }
}