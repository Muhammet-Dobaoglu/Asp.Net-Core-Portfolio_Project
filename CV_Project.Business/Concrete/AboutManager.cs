﻿using CV_Project.Business.Absract;
using CV_Project.Dal.Abstract;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }
        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

    }
}
