using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface IContactService
    {
        void Add(Contact contact);
        List<Contact> List();

        void Delete(Contact contact);
        Contact GetById(int id);

    }
}
