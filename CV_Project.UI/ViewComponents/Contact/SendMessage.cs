using CV_Project.Business.Concrete;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CV_Project.UI.ViewComponents.Contact
{
    public class SendMessage:ViewComponent

    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
            
       
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
