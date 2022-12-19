using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }

 

    }
}
