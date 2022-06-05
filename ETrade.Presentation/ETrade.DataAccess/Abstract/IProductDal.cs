using ETrade.Core.DataAccess;
using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        List<ProductImagesCustomModel> GetProductsWithImages();

        List<ProductImagesCustomModel> GetAll();

        List<CategoryProductsCustomModel> GetCategoryProduct(int categoryId, int? page);

        int CategoryProductCount(int categoryId);
        
        


    }
}
