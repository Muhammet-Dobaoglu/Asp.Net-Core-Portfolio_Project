using CV_Project.Business.Concrete;
using CV_Project.Business.ValidationRules;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.d1 = "Proje Listesi";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Listesi";
            var values = portfolioManager.TGetList();
            return View(values);
        }



        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.d1 = "Proje Ekleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio s)
        {           
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(s);

            if(results.IsValid)
            {
                portfolioManager.TAdd(s);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetById(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.d1 = "Düzenleme";
            ViewBag.d2 = "Projeler";
            ViewBag.d3 = "Proje Güncelle";
            var values = portfolioManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio Portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(Portfolio);

            if (results.IsValid)
            {
                portfolioManager.TUpdate(Portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
