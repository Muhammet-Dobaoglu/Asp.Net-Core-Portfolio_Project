using CV_Project.Dal.Abstract;
using CV_Project.Dal.Repository;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Dal.EntityFramework
{
   public  class EfToDoListDal:GenericRepository<ToDoList>, IToDoListDal
    {
    }
}
