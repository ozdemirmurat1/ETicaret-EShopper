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
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetByCategory(int id)
        {
            return _categoryDal.List(x=>x.Id==id);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }

        public int GetByIdString(string seoName)
        {
            var result = _categoryDal.Get(x => x.SeoName == seoName);
            if (result!=null)
            {
                return result.Id;
            }
            else
            {
                return 0;
            }
        }

        public Category GetCategory(string seoName)
        {
            return _categoryDal.Get(x => x.SeoName == seoName);
        }

        public Category GetParentId(int parentId)
        {
            return _categoryDal.Get(x => x.Id == parentId);
        }

        

        public List<Category> GetAll()
        {
            return _categoryDal.List();
        }

        public List<Category> ListWithParentId(int parentId)
        {
            return _categoryDal.List().FindAll(x => x.ParentId == parentId);
        }

        public List<Category> List()
        {
            var result = _categoryDal.List();
            return result;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
