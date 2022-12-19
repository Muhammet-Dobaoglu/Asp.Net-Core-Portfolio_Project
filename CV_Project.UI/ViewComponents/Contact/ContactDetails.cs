using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactManager=new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
