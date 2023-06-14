using Microsoft.AspNetCore.Mvc;
using mvcGiris.Models;
using mvcGiris.ViewModels;
using mvcTic.business.Abstract;
using mvcTic.data.Abstract;

namespace mvcGiris.Controllers
{
    public class HomeController:Controller
    {
        // http://localhost:5069/home

        private IProductService _productService;
            public HomeController(IProductService productService)
            {
                this._productService=productService;
            }
            

        public IActionResult index()
        {

             var ProductViewModel = new ProductListViewModel()
            {
                // Categories=categories,
                Products= _productService.GetAll()
            };

            return View(ProductViewModel);


            // http://localhost:5069/home/index

            // int saat = DateTime.Now.Hour;
            // ViewBag.mesaj = saat<12?"İyi Günler":"Günaydin";
            // //Farklı bir if yapısı-- saat 12den büyükse İyi günler değilse günaydı yaz
            // ViewBag.username="Sude";
            // //ViewBag viewe geçişte taşıma yapan bir çanta
            // return View();
            //Views klasörünün içerisine oluşturacağın cshtml dosyası aynı isimde olmalı

            // var product = new List<Product>()
            // {
            //     new Product
            //     {
            //         Name="Samsuns X3",
            //         Price=3700,
            //         Description="Telefonlar",
            //         IsApproved=true
            //     },
            //     new Product
            //     {
            //         Name="Samsung X6",
            //         Price=5800,
            //         Description="Telefonlar"
            //     }
            // };

            // // var categories = new List<Category>()
            // // {
            // //     new Category{Name="Apple Telefonlar",Description="Apple"},
            // //     new Category{Name="Samsung Telefonlar",Description="Samsung"},
            // //     new Category{Name="Bilgisayar",Description="Casper"}
            // // };
                
            // var ProductViewModel = new ProductViewModel()
            // {
            //     // Categories=categories,
            //     Products=product
            // };

            // return View(ProductViewModel);
        }
        public IActionResult about()
        {
            //// http://localhost:5069/home/about
            return View();
        }    

        public IActionResult contact()
        {
            //localhost:5069/home/contact
            return View("myView");
            //View Home klasörünün içine gidip MyView dosyasını arıyor
        }
    }
}