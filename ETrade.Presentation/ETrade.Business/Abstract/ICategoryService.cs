using ETrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> List();
        List<Category> GetAll();
        List<Category> ListWithParentId(int parentId);
        int GetByIdString(string seoName);

        List<Category> GetByCategory(int id);

        Category GetById(int id);

        Category GetParentId(int parentId);

        Category GetCategory(string seoName);

        void Add(Category category);
        void Delete(Category category);

        void Update(Category category);

    }
}
