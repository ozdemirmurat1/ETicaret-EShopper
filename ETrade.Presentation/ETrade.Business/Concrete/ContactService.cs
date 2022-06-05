using ETrade.Business.Abstract;
using ETrade.DataAccess.Abstract;
using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Concrete
{
    public class ContactService:IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactService(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
             _contactDal.Delete(contact);
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.Id == id);
        }

        public List<Contact> List()
        {
            return _contactDal.List();
        }
    }
}
