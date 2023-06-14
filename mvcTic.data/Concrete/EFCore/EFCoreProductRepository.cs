using mvcTic.data.Abstract;
using mvcGiris.entity;
using Microsoft.EntityFrameworkCore;

namespace mvcTic.data.Concrete.EFCore
{
    public class EFCoreProductRepository:EFCoreGenericRepository<Product,mvcTicContext>, IProductRepository
    //  public class IEFCoreProductRepository : IProductRepository
    {
        // private mvcTicContext db = new mvcTicContext();
        // public void Create(Product entity)
        // {
        //     db.Products.Add(entity);
        //     db.SaveChanges();
        // }

        // public void Delete (Product entity)
        // {
        //     throw new NotImplementedException();
        // }

        // public List<Product> GetAll()
        // {
        //     throw new NotImplementedException();
        // }

        // public Product GetById(int id)
        // {
        //     throw new NotImplementedException();
        // }

        // public void Update(Product entity)
        // {
        //     throw new NotImplementedException();
        // }

        public List<Product> GetPopularProducts()
        {
            using(var context = new mvcTicContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProductByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            using(var context = new mvcTicContext())
            {
                //her ürünün kategori bilgisini almamız içni önce productstan productcategory'e oradan da categorye gideceğiz 
                // ilk tabloyu bağlarken ınclude bi sonrakini bağlarken thenınclude kullanıyoruz
                var rtn = context.Products
                                    .Where(i=>i.ProductId==id)
                                    .Include(i=>i.ProductCategories)
                                    .ThenInclude(i=>i.Category)
                                    .FirstOrDefault();

                return rtn;
            }
        }

        List<Product> IProductRepository.GetProductByCategory(string name)
        {
            //metodu normalde public List<Product> GetProductByCategory(string name) olarak çağırması lazımdı bir hata lırsan kontrol et
            using(var context = new mvcTicContext())
            {
                var products = context.Products.AsQueryable();
                //AsQueryable biz sorguyu yazıyoruz ama veritabanına göndermeden ben üzerine bir linq sorgusu eklemek istiyorum demek
                
                if(!string.IsNullOrEmpty(name))
                {
                    products = products
                                    .Include(i=>i.ProductCategories)
                                    .ThenInclude(i=>i.Category)
                                    .Where(i=>i.ProductCategories.Any(a=>a.Category.Name.ToLower() == name.ToLower()));
                                    
                }
                return products.ToList();
            }
        }
    }
}