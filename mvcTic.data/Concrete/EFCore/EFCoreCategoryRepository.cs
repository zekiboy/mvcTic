using mvcTic.data.Abstract;
using mvcGiris.entity;

namespace mvcTic.data.Concrete.EFCore
{
    public class EFCoreCategoryRepository:EFCoreGenericRepository<Category,mvcTicContext>, ICategoryRepository
    {
        // private mvcTicContext db = new mvcTicContext();

        // public void Create(Category entity)
        // {
        //     db.Categories.Add(entity);
        //     db.SaveChanges();
        // }

        // public void Delete(Category entity)
        // {
        //     throw new NotImplementedException();
        // }

        // public List<Category> GetAll()
        // {
        //     throw new NotImplementedException();
        // }

        // public Category GetById(int id)
        // {
        //     throw new NotImplementedException();
        // }
        
        // public void Update(Category entity)
        // {
        //     throw new NotImplementedException();
        // }

        public List<Category> GetPopularCategories()
        {
            using(var context = new mvcTicContext())
            {
                return context.Categories.ToList();
            }
        }
    }
}