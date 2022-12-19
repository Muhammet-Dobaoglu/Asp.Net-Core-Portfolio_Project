using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.d1 = "Dashboard";
            ViewBag.d2 = "İstatistikler";
            ViewBag.d3 = "İstatistik Sayfası";
            return View();
        }
    }
}
