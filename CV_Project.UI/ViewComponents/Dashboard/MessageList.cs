using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.UI.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent

    {
        UserMessageManager  messageManager=new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke() 
        {
            var values = messageManager.GetUserMessagesWithService();
            return View(values);
        }
    }
}
