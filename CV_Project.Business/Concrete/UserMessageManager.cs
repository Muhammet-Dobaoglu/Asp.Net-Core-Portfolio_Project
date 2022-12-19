using CV_Project.Business.Absract;
using CV_Project.Dal.Abstract;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Business.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
       IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal UserMessageDal)
        {
            _userMessageDal = UserMessageDal;
        }

        public UserMessage TGetById(int id)
        {
            return _userMessageDal.GetByID(id);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public void TAdd(UserMessage t)
        {
            _userMessageDal.Insert(t);
        }
        public void TUpdate(UserMessage t)
        {
            _userMessageDal.Update(t);
        }
        public void TDelete(UserMessage t)
        {
            _userMessageDal.Delete(t);
        }

        public List<UserMessage> GetUserMessagesWithService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }
    }
}
