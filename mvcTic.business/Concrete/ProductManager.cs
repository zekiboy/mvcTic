using mvcTic.business.Abstract;
using mvcGiris.entity;
using mvcTic.data.Abstract;

namespace mvcTic.business.Concrete
{
    public class ProductManager : IProductService
    {
        
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetProductByCategory(string name)
        {
            return _productRepository.GetProductByCategory(name);
        }

        public Product GetProductDetails(int id)
        {
            return _productRepository.GetProductDetails(id);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}