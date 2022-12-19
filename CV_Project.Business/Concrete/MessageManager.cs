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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal MessageDal)
        {
            _messageDal = MessageDal;
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }
        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

    }
}
