using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Helpers
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        void Set(string key, object data);
        void Delete(string key);
        void Clear();

        /*
         product.id.1
         product.all.list
         product.id.2
         */
         
        void Clear(string header);
    }
}
