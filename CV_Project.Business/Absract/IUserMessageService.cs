using CV_Project.Dal.Abstract;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Business.Absract
{
   public interface IUserMessageService:IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessagesWithService();

    }
}
