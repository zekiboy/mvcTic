using mvcGiris.entity;

namespace mvcTic.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {

        // List<Category> GetAllData();
        // Category GetById(int id);
        // public void Create(Category entity);
        // public void Update(Category entity);
        // public void Delete(int id);


         List<Category> GetPopularCategories();

    }
}