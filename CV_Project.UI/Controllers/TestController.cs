using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
