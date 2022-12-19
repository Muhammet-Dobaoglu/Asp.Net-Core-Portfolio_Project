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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal ServiceDal)
        {
            _serviceDal = ServiceDal;
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }
        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

    }
}
