using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface IProductService
    {
        List<ProductImagesCustomModel> ProductWithImages();

        Product GetBySeoName(string seoName);
        Product GetById(int id);

        List<ProductImagesCustomModel> GetAll();

        void CountUp(Product product);

        List<CategoryProductsCustomModel> GetCategoryProducts(int categoryId, int? page);

        int TotalPage(int categoryId);

        List<Product> List();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        

        





    }
}
