using ETrade.Core.DataAccess;
using ETrade.DataAccess.Abstract;
using ETrade.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DataAccess.Concrete
{
    public class ProductDal : RepositoryBase<Product, ETradeContext>, IProductDal
    {
        public int CategoryProductCount(int categoryId)
        {
            using (var c=new ETradeContext())
            {
                return c.CategoryProducts.Count(x => x.CategoryId == categoryId);
            }
        }

        public List<ProductImagesCustomModel> GetAll()
        {
            using (ETradeContext c = new ETradeContext())
            {
                var result = (from p in c.Products
                              join pi in c.ProductImages
                              on p.Id equals pi.ProductId
                              select new ProductImagesCustomModel
                              {
                                  Description = p.Description,
                                  Id = p.Id,
                                  Image = pi.Name,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName,
                                  Status = p.Status

                              }).ToList();

                return result;
            }
        }

        public List<CategoryProductsCustomModel> GetCategoryProduct(int categoryId, int? page)
        {
            int pageProductCount = 9; // sayfa başı görünecek ürün adedi
            int takeProduct = 0;
            if (page==null || page==1)
            {
                takeProduct = 0;
            }
            else
            {
                takeProduct = (pageProductCount * (page.Value - 1));
            }
            using (ETradeContext c=new ETradeContext())
            {
                var result = (from p in c.Products
                              join cp in c.CategoryProducts
                              on p.Id equals cp.ProductId
                              where cp.CategoryId==categoryId                             
                              select new CategoryProductsCustomModel
                              {
                                  Status = p.Status,
                                  Sort = cp.Sort,
                                  Counter = p.Counter,
                                  Description = p.Description,
                                  Id = p.Id,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName
                              }).OrderBy(x => x.Sort).ToList();
                result = result.Skip(takeProduct).Take(pageProductCount).ToList();
                return result;
            }
        }

        public List<ProductImagesCustomModel> GetProductsWithImages()
        {
            using (ETradeContext c=new ETradeContext())
            {
                var result=(from p in c.Products
                           join pi in c.ProductImages                         
                           on p.Id equals pi.ProductId 
                           select new ProductImagesCustomModel 
                           {
                              Description=p.Description,
                              Id=p.Id,
                              Image=pi.Name,
                              Name=p.Name,
                              Price=p.Price,
                              SeoName=p.SeoName,
                              Status=p.Status
                              
                           }).ToList();

                return result;
            }
        }
       
    }
}
