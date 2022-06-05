using ETrade.Core.DataAccess;
using ETrade.DataAccess.Abstract;
using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DataAccess.Concrete
{
    public class OrderDal : RepositoryBase<Order, ETradeContext>, IOrderDal
    {

    }
}
