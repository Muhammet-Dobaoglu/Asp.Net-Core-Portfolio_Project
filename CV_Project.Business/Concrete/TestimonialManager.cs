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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal TestimonialDal)
        {
            _testimonialDal = TestimonialDal;
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }
        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

    }
}
