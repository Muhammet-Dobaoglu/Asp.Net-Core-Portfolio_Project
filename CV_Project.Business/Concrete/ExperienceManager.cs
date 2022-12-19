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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal ExperienceDal)
        {
            _experienceDal = ExperienceDal;
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }
        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

    }
}
