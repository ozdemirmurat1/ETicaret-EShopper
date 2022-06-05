using ETrade.Business.Abstract;
using ETrade.Business.Helpers;
using ETrade.DataAccess.Abstract;
using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Concrete
{
    public class ProductService:IProductService
    {
        private readonly IProductDal _productDal;
        private readonly ICacheManager _cacheManager;
        private readonly ICategoryDal _categoryDal;
        private readonly IProductImageDal _productImageDal;

        public ProductService(IProductDal productDal, ICacheManager cacheManager, ICategoryDal categoryDal, IProductImageDal productImageDal)
        {
            _productDal = productDal;
            _cacheManager = cacheManager;
            _categoryDal = categoryDal;
            _productImageDal = productImageDal;
        }

        public void CountUp(Product product)
        {
            product.Counter = product.Counter + 1;
            _productDal.Update(product);
        }

        public Product GetBySeoName(string seoName)
        {
            return _productDal.Get(x => x.SeoName == seoName);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(x => x.Id == id);
        }

        public List<ProductImagesCustomModel> ProductWithImages()
        {
            var cacheData = _cacheManager.Get<List<ProductImagesCustomModel>>("productwithimage.all");

            if (cacheData == null)
            {
                var result = _productDal.GetProductsWithImages();
                _cacheManager.Set("productwithimage.all", result);
                return result;
            }
            else
            {
                return cacheData;
            }
        }

        public List<ProductImagesCustomModel> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<CategoryProductsCustomModel> GetCategoryProducts(int categoryId, int? page)
        {
            var result = _productDal.GetCategoryProduct(categoryId, page); // ürünler
            var images = _productImageDal.List(); // bütün resimler
            //result.ForEach(x => x.Image = images.First(i => i.ProductId == x.Id).Name);

            foreach (var item in result)
            {
                var urunResmi = images.First(x => x.ProductId == item.Id);
                item.Image = urunResmi.Name;
            }

            return result;
        }

        public int TotalPage(int categoryId)
        {
            var productCount = _productDal.CategoryProductCount(categoryId);
            var modResult = productCount % 9;
            if (modResult>0)
            {
                return ((productCount - modResult) / 9) + 1;
            }
            else
            {
                return productCount / 9;
            }
        }

        public List<Product> List()
        {
            return _productDal.List();
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
