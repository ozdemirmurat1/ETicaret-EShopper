using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation.Areas.Admin.Helpers
{
    public interface IAdminChecker
    {
        bool Check(HttpRequest request);
    }
}
