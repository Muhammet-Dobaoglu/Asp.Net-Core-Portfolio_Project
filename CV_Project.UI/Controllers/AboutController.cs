using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewBag.d1 = "Düzenleme";
            ViewBag.d2 = "Hakkında";
            ViewBag.d3 = "Hakkında Sayfası";
            var values = aboutManager.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");

        }
    }
}
