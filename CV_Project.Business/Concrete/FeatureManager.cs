using CV_Project.Business.Absract;
using CV_Project.Dal.Abstract;
using CV_Project.Dal.EntityFramework;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Business.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }



        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }
        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }
    }
}
