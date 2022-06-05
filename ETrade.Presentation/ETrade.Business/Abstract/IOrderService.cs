using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);

        List<Order> List();

        void Delete(Order order);
        Order GetById(int id);
    }
}
