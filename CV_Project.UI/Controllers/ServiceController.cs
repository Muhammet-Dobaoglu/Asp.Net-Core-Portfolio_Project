using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            ViewBag.d1 = "Hizmet Listesi";
            ViewBag.d2 = "Hzimetler";
            ViewBag.d3 = "Hizmet Listesi";
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.d1 = "Hizmet Listesi";
            ViewBag.d2 = "Hzimetler";
            ViewBag.d3 = "Hizmet Ekleme";

            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service s)
        {

            serviceManager.TAdd(s);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetById(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.d1 = "Hizmet Listesi";
            ViewBag.d2 = "Hzimetler";
            ViewBag.d3 = "Hizmet Güncelle";
            var values = serviceManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");

        }
    }
}
