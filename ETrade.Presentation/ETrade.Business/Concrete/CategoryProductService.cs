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
    public class CategoryProductService:ICategoryProductService
    {
        private readonly ICategoryProductDal _categoryProductDal;

        public CategoryProductService(ICategoryProductDal categoryProductDal)
        {
            _categoryProductDal = categoryProductDal;
        }

        public void Add(CategoryProduct categoryProduct)
        {
            _categoryProductDal.Add(categoryProduct);
        }

        public void Delete(CategoryProduct categoryProduct)
        {
            _categoryProductDal.Delete(categoryProduct);
        }

        public CategoryProduct GetById(int id)
        {
            return _categoryProductDal.Get(x => x.Id == id);
        }

        public List<CategoryProduct> List()
        {
            return _categoryProductDal.List();
        }

        public void Update(CategoryProduct categoryProduct)
        {
            _categoryProductDal.Update(categoryProduct);
        }
    }
}
