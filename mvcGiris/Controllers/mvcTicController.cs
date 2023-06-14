using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvcGiris.entity;
using mvcGiris.Models;
using mvcGiris.ViewModels;
using mvcTic.business.Abstract;

namespace mvcGiris.Controllers
{
    public class mvcTicController:Controller
    {
        private IProductService _productService;

        public mvcTicController(IProductService productService)
        {
            this._productService = productService;
        }
        
        public IActionResult list(string category)
        {
            var ProductViewModel = new ProductListViewModel()
            {
                Products = _productService.GetProductByCategory(category)
            };
            
            return View(ProductViewModel);

        }

        public IActionResult details(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }

            // Product product = _productService.GetById((int)id);
            //category bilgilerini de almak için aşağıdaki metodu oluşturmuştuk. O yüzden yukarıdakiyle işimiz kalmadı burada
            
            Product product = _productService.GetProductDetails((int)id);

            if(product==null)
            {
                return NotFound();
            }

            return View(new ProductDetailModel{
                Product = product,
                Categories = product.ProductCategories.Select(i=>i.Category).ToList()
            });
            //biz zaten veritabanından bilgileri include ederek sorgulamıştık.
            //burada sorguladığımız verileri viewmodel içerisine paketliyoruz
        }
    }
}