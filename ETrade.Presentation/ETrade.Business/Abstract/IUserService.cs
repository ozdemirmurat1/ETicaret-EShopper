using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface IUserService
    {
        User Login(string username, string password, bool ısDeleted);
        User GetById(int userId);

        User AdminLogin(string username, string password, bool ısDeleted);

        List<User> List();
        

        void Delete(int id); // soft delete
        void Add(User userData);
        void Update(User userData);
        void Delete(User userData);

        
    }
}
