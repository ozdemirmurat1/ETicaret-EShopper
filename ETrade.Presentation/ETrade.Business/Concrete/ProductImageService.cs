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
    public class ProductImageService:IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageService(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void Add(ProductImage productImage)
        {
            _productImageDal.Add(productImage);
        }

        public void Delete(ProductImage productImage)
        {
            _productImageDal.Delete(productImage);
        }

        public ProductImage GetById(int id)
        {
            return _productImageDal.Get(x => x.Id == id);
        }

        public List<ProductImage> List(int productId=0)
        {
            if (productId>0)
            {
                return _productImageDal
                       .List(x => x.ProductId == productId)
                       .OrderBy(x => x.Sort)
                       .ToList();
            }
            return _productImageDal.List();
        }

        public void Update(ProductImage productImage)
        {
            _productImageDal.Update(productImage);
        }
    }
}
