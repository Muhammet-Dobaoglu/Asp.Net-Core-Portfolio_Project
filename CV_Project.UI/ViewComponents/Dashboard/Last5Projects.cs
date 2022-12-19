using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.ViewComponents.Dashboard
{
    public class Last5Projects: ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
           
            return View();
        }

    }
}
