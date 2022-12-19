using CV_Project.Business.Absract;
using CV_Project.Dal.Abstract;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Business.Concrete
{
public  class ToDoListManager:IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal ToDoListDal)
        {
            _toDoListDal = ToDoListDal;
        }

        public ToDoList TGetById(int id)
        {
            return _toDoListDal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void TAdd(ToDoList t)
        {
            _toDoListDal.Insert(t);
        }
        public void TUpdate(ToDoList t)
        {
            _toDoListDal.Update(t);
        }
        public void TDelete(ToDoList t)
        {
            _toDoListDal.Delete(t);
        }
    }
}
