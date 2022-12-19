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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _contactDal = ContactDal;
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }
        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

    }
}
