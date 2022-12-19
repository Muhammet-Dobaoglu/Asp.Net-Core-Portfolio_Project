using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
       


        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewBag.d1 = "Düzenleme";
            ViewBag.d2 = "Yetenekler";
            ViewBag.d3 = "Yetenek Güncelle";
            var values = featureManager.TGetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index","Default");

        }



    }
}
