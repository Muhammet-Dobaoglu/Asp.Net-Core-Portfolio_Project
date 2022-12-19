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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal SkillDal)
        {
            _skillDal = SkillDal;
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }
        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

    }
}
