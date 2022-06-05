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
    public class UserTokenService:IUserTokenService
    {
        private readonly IUserTokenDal _userTokenDal;

        public UserTokenService(IUserTokenDal userTokenDal)
        {
            _userTokenDal = userTokenDal;
        }

        public UserToken Get(string token)
        {
           var userToken= _userTokenDal.Get(x => x.TokenKey == token);
            return userToken;
        }
        public void Add(string token,int userId)
        {
            var tokenData = new UserToken()
            {
                CreateDate=DateTime.Now,
                TokenKey=token,
                Status=true,
                UserId=userId
            };
            _userTokenDal.Add(tokenData);
        }

        public int GetTokenUserId(string token)
        {
            var tokenData = _userTokenDal.Get(x => x.TokenKey == token && x.Status != false);
            if (tokenData==null)
            {
                return 0;
            }
            else
            {
                return tokenData.UserId;
            }
        }

        public List<UserToken> List()
        {
            return _userTokenDal.List();
        }

        public UserToken GetById(int id)
        {
            return _userTokenDal.Get(x => x.Id == id);
        }

        public void Delete(UserToken userToken)
        {
            _userTokenDal.Delete(userToken);
        }
    }
}
