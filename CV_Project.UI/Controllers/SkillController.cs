using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace CV_Project.UI.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Yetenek Listesi";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Listesi";
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.d1 = "Yetenek Ekleme";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Ekleme";

            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill s)
        {

            skillManager.TAdd(s);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetById(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.d1 = "Düzenleme";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Güncelle";
            var values = skillManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
      
        }






    }
}
