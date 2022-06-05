using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Helpers
{
    public class CacheManager : ICacheManager
    {
        private readonly IMemoryCache _memoryCache;   // database'deki dataları bilgisayardaki ram'de saklar.
        public static ConcurrentBag<string> keys = new ConcurrentBag<string>();  // aynı anda generic liste birden fazla erişim isteği
                                                                                 // olursa sıraya sokar.

        public CacheManager(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void Clear()
        {
            var list = keys.ToList();
            foreach (var item in list)
            {
                Delete(item);
                RemoveKey(item);
            }
        }

        public void Clear(string header)
        {
            var list = keys.AsQueryable().Where(x => x.StartsWith(header)).ToList();
            foreach (var item in list)
            {
                Delete(item);
                RemoveKey(item);
            }
        }

        public void Delete(string key)
        {
            _memoryCache.Remove(key);
            RemoveKey(key);
        }

        public T Get<T>(string key)
        {
            var result = _memoryCache.Get<T>(key);
            if (result==null)
            {
                Delete(key);
            }
            return result;
        }

        public void Set(string key, object data)
        {
            RemoveKey(key);
            keys.Add(key);
            _memoryCache.Set(key, data);
        }
        private void RemoveKey(string key)
        {
            var data = keys.AsQueryable().Where(x => x == key).FirstOrDefault();
            if (data!=null)
            {
                data = null;
            }
            keys.ToList().Remove(key);
        }
    }
}
