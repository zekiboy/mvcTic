using mvcGiris.entity;

namespace mvcTic.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        // // List<Product> GetAll();
        // // Product GetById(int id);
        // // public void Create(Product entity);
        // // public void Update(Product entity);
        // // public void Delete(int id);
        List<Product> GetPopularProducts();

        Product GetProductDetails(int id);
        List<Product> GetProductByCategory(string name);

 
    }
}