// using Microsoft.AspNetCore.Mvc;
// // using mvcGiris.Models;
// using mvcGiris.entity;
// using mvcGiris.ViewModels;
// // using mvcGiris.Data;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace mvcGiris.Controllers
// {
//     public class ProductController:Controller
//     {
//         //localhost:5069/product

//         public IActionResult index()
//         {
//             //localhost:5069/product/index

//             var product = new Product
//             {
//                 Name="Samsung",
//                 Price=20000,
//                 Description="Telefon"
//             };

//             //Model, ViewBag ve ViewData View'e veri taşıma yöntemleri, araştır
//             //Henüz bir category tablosu oluşturmadık. Sadece string olarak tuttuk
//             ViewData["Category"]="Telefon";

//             //oluşturduğumuz product nesnesini, ViewData yöntemi ile View'e taşıdık
//             ViewData["Product"]=product;
//             return View();
//         }
        
//         public IActionResult list(int? id, string q)
//         {
//             //localhost:5069/product/list
//             return View();
//             // var products = ProductRepository.Products;
//             // if(id!=null)
//             // {
//             //     products=products.Where(p=>p.CategoryId==id).ToList();
//             // }    
            
//             // if(!string.IsNullOrEmpty(q))
//             // {
//             //     //search butonunda alınan string ifadeyi q'ya eşitliyor. daha sonra burada name ya da descriptionda geçiyor mu kontrol ediyoruz
//             //     products=products.Where(i=>i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
//             // }
//             // var ProductViewModel = new ProductViewModel()
//             // {
//             //     Products=products
//             //     //yukarıda da ProductRepository.Products olarak çektiğimiz için kategori filtreleme yapmıyor. Oyüzden aşağıyı yorum satırına aldık
//             //     // Products=ProductRepository.Products
//             //     //ProductRepository yazınca altı kırmızı çizili, ctrl+nokta yap yolu seç

//             // };
//             // return View(ProductViewModel);



//             // var product = new List<Product>()
//             // {
//             //     new Product
//             //     {
//             //         Name="Samsuns X3",
//             //         Price=3700,
//             //         Description="Telefonlar",
//             //         IsApproved=true
//             //     },
//             //     new Product
//             //     {
//             //         Name="Samsung X6",
//             //         Price=5800,
//             //         Description="Telefonlar"
//             //     }
//             // };

//             // var category =new Category()
//             // {
//             //     Name="Telefon",
//             //     Description="Telefonlar"
//             // };

//             // var categories = new List<Category>()
//             // {
//             //     new Category{Name="Telefon",Description="Apple"},
//             //     new Category{Name="Telefon",Description="Samsung"},
//             //     new Category{Name="Bilgisayar",Description="Casper"}
//             // };
                
//             // var ProductViewModel = new ProductViewModel()
//             // {
//             //     // Categories=categories,
//             //     Products=product
//             // };

//             // return View(ProductViewModel);
//         }

//         public IActionResult details(int id)
//         {   
//             // details(int id)
//             //localhost:5069/product/details
//             //return View();

//             // var p = new Product();
//             //p nesnesi oluştururken Product altı kırmızı çizgili gelecek
//             //üstüne tıkla ctrl+nokta yap using mvcGirisModel yani ilgili Modeli seç
//             // p.Name="Macbook Pro M2";
//             // p.Price=40000;
//             // p.Description="Computer";
//             // return View(p);
//             // return View(ProductRepository.GetProductById(id));
//             return View();
//         }

//         [HttpGet]
//         public IActionResult create()
//         {
//             // ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
//             return View();
//         }

//         [HttpPost]
//         public IActionResult create_add(Product p)
//         {
//             // ProductRepository.AddProduct(p);
//             return RedirectToAction("list");
//         }

//         [HttpGet]
//         public IActionResult edit(int id)
//         {
//             // ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
//             // return View(ProductRepository.GetProductById(id));
//             return View();
//         }

//         [HttpPost]
//         public IActionResult edit_product(  Product p)
//         {
//             // ProductRepository.EditProduct(p);
//             return RedirectToAction("list");
//         }

//         [HttpGet]
//         public IActionResult delete(int id)
//         {
//             // ViewBag.Name=new SelectList(ProductRepository.Products,"ProductId","Name");
//             // return View(ProductRepository.GetProductById(id));
//             return View();
//         }

//         [HttpPost]
//         public IActionResult delete_product(Product p)
//         {
//             // ProductRepository.DeleteProduct(p);
//             return RedirectToAction("list");
//         }



//     }
// }