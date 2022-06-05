using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Helpers
{
    public class AdminChecker : IAdminChecker
    {
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;

        public AdminChecker(ICookieHelper cookieHelper, IUserService userService, IUserTokenService userTokenService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTokenService = userTokenService;
        }

        public bool Check(HttpRequest request)
        {
            var token = _cookieHelper.Get(CookieTypes.admin, request);
            if (token != null)
            {
                var userId = _userTokenService.Get(token).UserId;
                var user = _userService.GetById(userId);
                if (user.IsAdmin.Value) return true;
                return false;
            }
            else return false;
        }
    }
}
