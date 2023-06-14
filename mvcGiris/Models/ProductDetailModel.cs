using mvcGiris.entity;

namespace mvcGiris.Models
{
    public class ProductDetailModel
    {
        public Product Product{get; set;}
        public List<Category> Categories { get; set; }
    }
}