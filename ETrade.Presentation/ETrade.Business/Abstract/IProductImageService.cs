using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface IProductImageService
    {
        List<ProductImage> List(int productId=0);
        ProductImage GetById(int id);

        void Add(ProductImage productImage);
        void Update(ProductImage productImage);
        void Delete(ProductImage productImage);
    }
}
