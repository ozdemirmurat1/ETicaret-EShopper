using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface IUserTokenService
    {
        UserToken Get(string token);
        void Add(string token, int userId);

        int GetTokenUserId(string token);

        List<UserToken> List();
        UserToken GetById(int id);
        void Delete(UserToken userToken);
    }
}
