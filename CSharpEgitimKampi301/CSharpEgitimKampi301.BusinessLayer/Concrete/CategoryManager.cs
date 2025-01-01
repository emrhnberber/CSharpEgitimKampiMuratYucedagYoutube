using CSharpEgitimKampi301.EntitiyLayer.Concrate;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.BusinessLayer.Abstruct;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TDelete(Category entity)
        {
            _categorydal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
           return _categorydal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categorydal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
           _categorydal.Update(entity);
        }
    }
}