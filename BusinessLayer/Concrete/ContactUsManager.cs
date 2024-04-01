using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs t)
        {
<<<<<<< HEAD
            _contactUsDal.Insert(t);
=======
            throw new NotImplementedException();
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
<<<<<<< HEAD
            _contactUsDal.ContactUsStatusChangeToFalse(id);
=======
            throw new NotImplementedException();
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        }

        public void TDelete(ContactUs t)
        {
<<<<<<< HEAD
            _contactUsDal.Delete(t);
=======
            throw new NotImplementedException();
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        }

        public ContactUs TGetByID(int id)
        {
<<<<<<< HEAD
            return _contactUsDal.GetByID(id);
=======
            throw new NotImplementedException();
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUs t)
        {
<<<<<<< HEAD
            _contactUsDal.Update(t);
=======
            throw new NotImplementedException();
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        }
    }
}
