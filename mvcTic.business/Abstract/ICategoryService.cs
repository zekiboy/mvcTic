using mvcGiris.entity;

namespace mvcTic.business.Abstract
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void Create(Category entity);
        public void Update(Category entity);
        public void Delete(int id);

       
        
    }
}