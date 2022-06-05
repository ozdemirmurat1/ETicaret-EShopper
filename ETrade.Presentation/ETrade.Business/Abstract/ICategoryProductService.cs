using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface ICategoryProductService
    {
        List<CategoryProduct> List();
        CategoryProduct GetById(int id);
        void Add(CategoryProduct categoryProduct);
        void Delete(CategoryProduct categoryProduct);

        void Update(CategoryProduct categoryProduct);
    }
}
