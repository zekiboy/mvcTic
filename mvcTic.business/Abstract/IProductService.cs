using mvcGiris.entity;

namespace mvcTic.business.Abstract
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public void Create(Product entity);
        public void Update(Product entity);
        public void Delete(int id);
        Product GetProductDetails(int id);
        List<Product> GetProductByCategory(string name);

    }
}