using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Deneyim Listesi";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.d1 = "Deneyim Ekleme";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Ekleme";

            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience s)
        {

            experienceManager.TAdd(s);
            return RedirectToAction("Index");
        }
      
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.d1 = "Düzenleme";
            ViewBag.d2 = "Deneyimler";
            ViewBag.d3 = "Deneyim Güncelle";
            var values = experienceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience Experience)
        {
            experienceManager.TUpdate(Experience);
            return RedirectToAction("Index");

        }
    }
}
